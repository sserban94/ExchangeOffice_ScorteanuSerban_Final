using ExchangeOffice_ScorteanuSerban.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Data.Sqlite;

namespace ExchangeOffice_ScorteanuSerban
{
    public partial class PreviousTransactionsForm : Form
    {
        #region Attributes
        // remember the db file has to be in the same folder as the exe
        public string connectionString = "Data source=database.db";
        #endregion
        public PreviousTransactionsForm()
        {
            InitializeComponent();
        }
        #region Methods

        private void ImportTransactionFromDb()
        {
            MainForm.transactions.Clear();
            string query = "SELECT * FROM ExchangeTransactions";
            // remember this has to be opened and afterwards disposed of
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                // no parameters here
                // always open connection
                connection.Open();
                // exec reader to return more than 1, exec scalar to return 1, exec nonq none
                // exec reader return a data reader - its base implements IDisposable
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    // this returns a bool
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        double initialSum = (double)reader["InitialSum"];
                        double finalSum = (double)reader["FinalSum"];
                        string fromCurrency = (string)reader["FromCurrency"];
                        string toCurrency = (string)reader["ToCurrency"];
                        string conversionType = (string)reader["ConversionType"];
                        double rate = (double)reader["ConversionRate"];
                        DateTime checkedRateDay = DateTime.Parse((string)reader["LastChecked"]);
                        string operatorType = (string)reader["Details"];
                        Currency fromCoin = new Currency(fromCurrency);
                        Currency toCoin = new Currency(toCurrency);
                        ExchangeRate exchangeRate = new ExchangeRate(conversionType, operatorType,
                            rate, checkedRateDay);
                        Transaction transaction = new Transaction(id, initialSum, finalSum, fromCoin, toCoin, exchangeRate);

                        MainForm.transactions.Add(transaction);
                    }
                }
            }

        }   // it works yeey

        private void DeleteTransactionFromDb()
        {

            string query = "DELETE FROM ExchangeTransactions WHERE Id = @id";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);

                foreach (DataGridViewRow row in this.dgvTransactions.SelectedRows)
                {
                    Transaction t = row.DataBoundItem as Transaction;

                    command.Parameters.AddWithValue("@id", t.Id);
                }

                connection.Open();

                command.ExecuteNonQuery();
            }
        }   // this also works yeey


        #endregion

        #region Events
        private void PreviousTransactionsForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = MainForm.transactions;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSerializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("transaction.bin"))
            {
                formatter.Serialize(stream, MainForm.transactions);
            }
        }

        // how do I refresh when Deserealizing if I'm using DataBinding?
        private void btnDeserealizeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("transaction.bin"))
            {
                // not the most elegant solution but it triggers the list changed event!
                MainForm.transactions.Clear();
                var t = (BindingList<Transaction>)formatter.Deserialize(stream);
                foreach(var trans in t)
                {
                    MainForm.transactions.Add(trans);
                }
                //MainForm.transactions = (BindingList<Transaction>)formatter.Deserialize(stream);


            }
            
        }

        private void btnSerializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Transaction>));
            using (FileStream stream = File.Create("transactions.xml"))
            {
                serializer.Serialize(stream, MainForm.transactions);
            }
        }

        private void btnDeserializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Transaction>));
            using (FileStream stream = File.OpenRead("transactions.xml"))
            {
                MainForm.transactions.Clear();
                var t = (BindingList<Transaction>)serializer.Deserialize(stream);
                foreach (var trans in t)
                {
                    MainForm.transactions.Add(trans);
                }
                //MainForm.transactions = (BindingList<Transaction>)serializer.Deserialize(stream);
            }
        }

        private void btnSerializeJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter writer = File.CreateText("transactions.json"))
            {
                serializer.Serialize(writer, MainForm.transactions);
            }
        }

        private void btnDeserializeJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = File.OpenText("transactions.json"))
            {
                MainForm.transactions.Clear();
                var t = (BindingList<Transaction>)serializer.Deserialize(reader, typeof(BindingList<Transaction>));
                foreach (var trans in t)
                {
                    MainForm.transactions.Add(trans);
                }
                //MainForm.transactions = (BindingList<Transaction>)serializer.Deserialize(reader, typeof(BindingList<Transaction>));
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export to CSV";
            // save as
            saveFileDialog.Filter = "CSV File| *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("Initial Sum,Final Sum,From Coin,To Coin,Conversion Rate");
                    foreach (Transaction transaction in MainForm.transactions)
                    {
                        // to short date string so it won't get the time as well
                        // use " " to wrap the name so it can contain space between names
                        writer.WriteLine($"\"{transaction.InitialSum}\",\"{transaction.FinalSum}\"," +
                            $"\"{transaction.FromCoin}\",\"{transaction.ToCoin}\",\"{transaction.Rate}\"");
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import from CSV";
            openFileDialog.Filter = "CSV File| *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainForm.transactions.Clear();
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    reader.ReadLine();
                    while (reader.Peek() != -1)
                    {
                        string line = reader.ReadLine().ToString();
                        // wholy moly this was annoying
                        // I think BindingLists initialize the list with a temporary object
                        // the list count was 1 before even adding an object to it                        
                        Transaction transaction = new Transaction();
                        char[] delimiterChars = { ' ', ',', ':', '|', '\\', '\"' };
                        //transaction.InitialSum = Double.Parse(line.Split(',')[0]);
                        //transaction.FinalSum = Double.Parse(line.Split(',')[1]);
                        //transaction.FromCoin.Coin = line.Split(',')[2];
                        //transaction.ToCoin.Coin = line.Split(',')[3];
                        //string longRate = line.Substring(line.IndexOf(line.Split(',')[4]), line.Length);
                        //  I WILL FINISH THIS!

                        string[] words = line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                        transaction.InitialSum = Double.Parse(words[0]);
                        transaction.FinalSum = Double.Parse(words[1]);
                        transaction.FromCoin = new Currency(words[2]);
                        transaction.ToCoin = new Currency(words[3]);
                        transaction.Rate = new ExchangeRate();
                        transaction.Rate.ConversionName = words[5];
                        transaction.Rate.Rate = Double.Parse(words[7]);
                        transaction.Rate.CheckedRateDay = DateTime.Parse(words[9]);
                        transaction.Rate.OperatorType = words[10];


                        MainForm.transactions.Add(transaction);
                        //if (reader.Peek() == -1)
                        //{
                        //    break;
                        //}
                    }
                }
            }
        }
        

        private void importFromdbFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportTransactionFromDb();
        }

        private void dgvTransactions_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DeleteTransactionFromDb();
        }
        //private void exportTodbFileToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (Transaction transaction in MainForm.transactions)
        //    {

        //    }
        //}
        #endregion


    }
}
