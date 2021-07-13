using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// I have activated ENABLE ALLOW FOCUS CHANGE and for some time I could press X, now the 
// error provider overrides it
// still it works if I just click a conversion type 
namespace ExchangeOffice_ScorteanuSerban.Entities
{
    public partial class NewTransactionForm : Form
    {
        #region Attributes
        // remember the db file has to be in the same folder as the exe
        public string connectionString = "Data source=database.db";
        Transaction transaction;
        long id;
        double initialSum;
        double finalSum;
        Currency fromCoin;
        Currency toCoin;
        ExchangeRate finalRate;
        

        #endregion
        public NewTransactionForm()
        {
            InitializeComponent();
            DisplayCurrency();


        }
        #region Methods

        private void DisplayCurrency()
        {

            cbFirstCurrency.DisplayMember = "Coin";
            foreach (var currency in MainForm.currencies)
            {
                cbFirstCurrency.Items.Add(currency);
            }
            cbSecondCurrency.DisplayMember = "Coin";
            foreach (var currency in MainForm.currencies)
            {
                cbSecondCurrency.Items.Add(currency);
            }
        }


        private void CalculateFinalSum()
        {
            var typeOfCurrency = cbFirstCurrency.SelectedItem.ToString();
            var typeOfCurrency2 = cbSecondCurrency.SelectedItem.ToString();
            initialSum = Double.Parse(tbInitialSum.Text);


            var RateType = typeOfCurrency + typeOfCurrency2;

            foreach (ExchangeRate rate in MainForm.exchangeRates)
            {
                if (rate.ConversionName == RateType)
                {
                    if (rate.OperatorType == "Multiplication")
                    {
                        finalSum = Math.Round(initialSum * rate.Rate, 2);
                        tbFinalSum.Text = finalSum.ToString();
                        finalRate = new ExchangeRate();
                        finalRate.Rate = rate.Rate;
                        finalRate.OperatorType = rate.OperatorType;
                        finalRate.ConversionName = rate.ConversionName;
                        finalRate.CheckedRateDay = DateTime.Now;
                    }
                    else
                    {
                        finalSum = Math.Round(initialSum / rate.Rate, 2);
                        tbFinalSum.Text = finalSum.ToString();
                        finalRate = new ExchangeRate();
                        finalRate.Rate = rate.Rate;
                        finalRate.OperatorType = rate.OperatorType;
                        finalRate.ConversionName = rate.ConversionName;
                        finalRate.CheckedRateDay = DateTime.Now;
                    }
                }
            }
            
            fromCoin = new Currency(typeOfCurrency);
            toCoin = new Currency(typeOfCurrency2);

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show(
                    "Nice try!",    // message
                    "Error",                        // title
                    MessageBoxButtons.OK,           // button
                    MessageBoxIcon.Error);          // icon

                return;
            }
            CalculateFinalSum();
            AddTransaction();
            
            btnConvert.Enabled = false;
        }


        // buggy - table not found...
        private void ExportTransactionToDb()
        {
            string query = "INSERT INTO ExchangeTransactions (InitialSum, FinalSum, FromCurrency, ToCurrency, ConversionType, ConversionRate, LastChecked, Details) VALUES" +
                " (@initialSum, @finalSum, @fromCoin, @toCoin, @ConversionType, @ConversionRate, @LastChecked, @Details);" +
                "SELECT last_insert_rowid();";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@initialSum", transaction.InitialSum);
                command.Parameters.AddWithValue("@finalSum", transaction.FinalSum);
                command.Parameters.AddWithValue("@fromCoin", transaction.FromCoin.Coin);
                command.Parameters.AddWithValue("@toCoin", transaction.ToCoin.Coin);
                command.Parameters.AddWithValue("@ConversionType", transaction.Rate.ConversionName);
                command.Parameters.AddWithValue("@ConversionRate", transaction.Rate.Rate);
                command.Parameters.AddWithValue("@LastChecked", transaction.Rate.CheckedRateDay);
                command.Parameters.AddWithValue("@Details", transaction.Rate.OperatorType);


                connection.Open();

                long id = (long)command.ExecuteScalar(); //get id
                transaction.Id = id;
            }
        }

        


        private void AddTransaction()
        {
            try
            {
                transaction = new Transaction(initialSum, finalSum, fromCoin, toCoin, finalRate);
                ExportTransactionToDb();
                MainForm.transactions.Add(transaction);
            }
            catch(ArgumentException e)
            {
                MessageBox.Show("Invalid argument");
            }
            catch(InvalidSumException except)
            {
                MessageBox.Show(except.Message);
            }
            finally
            {
                Debug.WriteLine("I am displayed by default");
            }
        }

        #endregion


        #region Events
        private void tbInitialSum_Validating(object sender, CancelEventArgs e)
        {
            if (tbInitialSum.Text.Length < 1)
            {
                errorProvider.SetError(tbInitialSum, "Field cannot be empty");
                e.Cancel = true;
            }

        }

        private void tbInitialSum_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbInitialSum, null);
        }

        private void tbInitialSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }



        

        private void cbSecondCurrency_Validating(object sender, CancelEventArgs e)
        {

            var secondCurrency = cbSecondCurrency.Text.Trim().ToString();
            var firstCurrency = cbFirstCurrency.Text.Trim().ToString();

            if (string.IsNullOrWhiteSpace(secondCurrency))
            {
                errorProvider.SetError(cbSecondCurrency, "Must select a second currency");
                e.Cancel = true;
            }
            else if (cbSecondCurrency.Text == cbFirstCurrency.Text)
            {
                errorProvider.SetError(cbSecondCurrency, "The second currency must be different");
                e.Cancel = true;
            }
        }

        private void cbSecondCurrency_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(cbSecondCurrency, null);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Escape)
        //    {
        //        errorProvider.SetError(tbInitialSum, null);
        //        this.Close();
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}
