using ExchangeOffice_ScorteanuSerban.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Net;



namespace ExchangeOffice_ScorteanuSerban
{
    public partial class MainForm : Form
    {
        #region Attributes
        public static List<Currency> currencies;
        public static BindingList<Transaction> transactions;
        public static BindingList<ExchangeRate> exchangeRates;
        public static string connectionString = "Data source=database.db";

        #endregion
        public MainForm()
        {
            InitializeComponent();

            currencies = new List<Currency>();
            transactions = new BindingList<Transaction>();
            exchangeRates = new BindingList<ExchangeRate>();

            
            
            
        }
        #region Methods
        private void LoadCurrencies()
        {
            currencies.Add(new Currency("Euro"));
            currencies.Add(new Currency("USD"));
            currencies.Add(new Currency("Ron"));

        }

        private void LoadExchangeRates()
        {
            #region Almost Webscrapping
            // This is where is WebScrape two websited in order to get the values for my currencies
            string websiteRo;
            using (var client = new WebClient())
            {
                client.Headers.Add("User-Agent", "C# console program");

                string url = "https://www.bnr.ro/Cursul-de-schimb-524-Mobile.aspx";
                string content = client.DownloadString(url);
                websiteRo = content;
                //Console.WriteLine(content);
            }
            string websiteCom;
            using (var client = new WebClient())
            {
                client.Headers.Add("User-Agent", "C# console program");

                string url = "https://www.x-rates.com/calculator/?from=EUR&to=USD&amount=1";
                string content = client.DownloadString(url);
                websiteCom = content;
                //Console.WriteLine(content);
            }

            string euroWithComma = websiteRo.Substring(websiteRo.IndexOf("c2'>EUR</td>") + 16, 6).Trim();
            string euro = euroWithComma.Replace(',', '.');
            double euroToRonRate = double.Parse(euro);

            string usdWithComma = websiteRo.Substring(websiteRo.IndexOf("c2'>USD</td>") + 16, 6).Trim();
            string usd = usdWithComma.Replace(',', '.');
            double usdToRonRate = double.Parse(usd);

            string euroDollarWithComma = websiteCom.Substring(websiteCom.IndexOf("ccOutputRslt") + 14, 5).Trim();
            string euroDollar = euroDollarWithComma.Replace(',', '.');
            double euroToDollarRate = double.Parse(euroDollar);
            #endregion
            // Euro-Dollar, Euro-Lei, Dollar-Lei
            // Adding rates here
            exchangeRates.Add(new ExchangeRate("EuroRon", "Multiplication", euroToRonRate, DateTime.Now));
            exchangeRates.Add(new ExchangeRate("RonEuro","Division", euroToRonRate, DateTime.Now));
            exchangeRates.Add(new ExchangeRate("USDRon", "Multiplication", usdToRonRate, DateTime.Now));
            exchangeRates.Add(new ExchangeRate("RonUSD","Division", usdToRonRate, DateTime.Now));
            exchangeRates.Add(new ExchangeRate("EuroUSD", "Multiplication", euroToDollarRate, DateTime.Now));            
            exchangeRates.Add(new ExchangeRate("USDEuro", "Division", euroToDollarRate, DateTime.Now));            
        }

        #endregion

        #region Events
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            NewTransactionForm newTransactionForm = new NewTransactionForm();
            newTransactionForm.Show();
        }

        private void btnCheckPrevious_Click(object sender, EventArgs e)
        {
            PreviousTransactionsForm previousTransactionsForm = new PreviousTransactionsForm();
            previousTransactionsForm.Show();
        }

        private void btnCheckRates_Click(object sender, EventArgs e)
        {
            ExchangeRatesForm exchangeRatesForm = new ExchangeRatesForm();
            exchangeRatesForm.Show();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            try
            {
                LoadCurrencies();
                LoadExchangeRates();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        // What I intended here was a combination of Ctrl and a number in order to avoid clicking on the buttons
        // unfortunately not working and I can't find a solution
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // bug - e.control is false so this doesn't work :(
            if (e.Control == true && e.KeyCode.ToString() == "1")
            {
                btnMakeTransaction.PerformClick();
            }
            if (e.Control == true && e.KeyCode.ToString() == "2")
            {
                btnCheckPrevious.PerformClick();
            }
            if (e.Control == true && e.KeyCode.ToString() == "3")
            {
                btnCheckRates.PerformClick();
            }

        }
    }
}
