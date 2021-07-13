using ControlLibrary;
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

namespace ExchangeOffice_ScorteanuSerban
{
    public partial class ExchangeRatesChartForm : Form
    {
        public ExchangeRatesChartForm()
        {
            InitializeComponent();
        }

        private void bntUpdateChart_Click(object sender, EventArgs e)
        {
            
            
            List<BarChartValue> barList = new List<BarChartValue>();

            foreach (Currency currency in MainForm.currencies)
            {
                foreach (ExchangeRate exchangeRate in MainForm.exchangeRates)
                {
                    if (exchangeRate.ConversionName.StartsWith(currency.Coin) && exchangeRate.ConversionName.EndsWith("Ron"))
                    {
                        barList.Add(new BarChartValue(currency.Coin, (float)exchangeRate.Rate));
                    }
                }
            }

            barChart1.Data = barList;
        }
    }
}
