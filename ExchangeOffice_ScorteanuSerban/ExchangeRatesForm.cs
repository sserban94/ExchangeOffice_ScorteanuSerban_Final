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
    public partial class ExchangeRatesForm : Form
    {
        public ExchangeRatesForm()
        {
            InitializeComponent();
            displayCurrencies();
        }

        #region Methods
        // displaying all the currencies in a combo bpx
        private void displayCurrencies()
        {
            lvCurrency.Items.Clear();
            foreach (Currency currency in MainForm.currencies)
            {
                if (currency.Coin == "Ron")
                {
                    continue;
                }
                ListViewItem item = new ListViewItem(currency.Coin);
                for (int i = 0; i < MainForm.exchangeRates.Count; i++)
                {
                    if (MainForm.exchangeRates[i].ConversionName.StartsWith(currency.Coin) && MainForm.exchangeRates[i].ConversionName.EndsWith("Ron"))
                    {
                        item.SubItems.Add(MainForm.exchangeRates[i].Rate.ToString());
                        item.SubItems.Add(MainForm.exchangeRates[i].CheckedRateDay.ToString());
                    }
                }
                lvCurrency.Items.Add(item);
                item.Tag = currency;
            }
        }

        #endregion

        #region Events
        private void btnDetails_Click(object sender, EventArgs e)
        {
            lvCurrency.View = View.Details;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lvCurrency.View = View.List;
        }

        private void btnLargeIcon_Click(object sender, EventArgs e)
        {
            lvCurrency.View = View.LargeIcon;
        }

        private void btnSmallIcon_Click(object sender, EventArgs e)
        {
            lvCurrency.View = View.SmallIcon;
        }

        private void btnTile_Click(object sender, EventArgs e)
        {
            lvCurrency.View = View.Tile;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvCurrency.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a currency!");
                return;
            }
            if (MessageBox.Show(
                "Are you sure?",
                "Delete currency",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem listViewItem = lvCurrency.SelectedItems[0];

                // add tag to DisplayParticipants() method
                Currency currency = (Currency)listViewItem.Tag;
                MainForm.currencies.Remove(currency);
                displayCurrencies();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetails_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to change the layout to details";
        }

        private void btnDetails_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnTile_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to change the layout to Tile";

        }

        private void btnTile_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void btnList_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to change the layout to list";

        }

        private void btnList_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void btnSmallIcon_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to change the layout to Small Icon";

        }

        private void btnSmallIcon_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void btnLargeIcon_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to change the layout to Large Icon";

        }

        private void btnLargeIcon_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to exit this form and return to Main Menu";

        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to delete the selected data";

        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnChart_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to view data in chart";
        }

        private void btnChart_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ExchangeRatesChartForm exchangeRatesChartForm = new ExchangeRatesChartForm();
            exchangeRatesChartForm.Show();
        }

        
        #endregion
    }
}
