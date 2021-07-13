using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice_ScorteanuSerban.Entities
{
    [Serializable]
    public class Transaction : INotifyPropertyChanged
    {

        private double initialSum;
        private double finalSum;
        private Currency fromCoin;
        private Currency toCoin;
        private ExchangeRate rate;

        #region Attributes
        public long Id { get; set; }
        public double InitialSum
        {
            get { return initialSum; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidSumException(value);
                }
                initialSum = value;
                NotifyPropertyChanged("InitialSum");
            }
        }
        public double FinalSum
        {
            get { return finalSum; }
            set
            {
                finalSum = value;
                NotifyPropertyChanged("FinalSum");
            }
        }
        public Currency FromCoin
        {
            get { return fromCoin; }
            set
            {
                fromCoin = value;
                NotifyPropertyChanged("FromCoin");
            }
        }
        public Currency ToCoin
        {
            get { return toCoin; }
            set
            {
                toCoin = value;
                NotifyPropertyChanged("ToCoin");
            }
        }
        public ExchangeRate Rate
        {
            get { return rate; }
            set
            {
                rate = value;
                NotifyPropertyChanged("Rate");
            }
        }

        #endregion

        #region Constructors
        public Transaction()
        {
            //InitialSum = 0;
            //FinalSum = 0;
            //FromCoin = new Currency();
            //ToCoin = new Currency();
            //Rate = null;
        }

        public Transaction(double initialSum, double finalSum, Currency fromCoin,
            Currency toCoin, ExchangeRate rate)
        {
            InitialSum = initialSum;
            FinalSum = finalSum;
            FromCoin = fromCoin;
            ToCoin = toCoin;
            Rate = rate;
        }

        public Transaction(long id, double initialSum, double finalSum, Currency fromCoin,
            Currency toCoin, ExchangeRate rate)
            :this(initialSum, finalSum, fromCoin, toCoin, rate)
        {
            Id = id;
        }

        #endregion



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            // REMEMBER NOT TO USE THIS WHEN MULTITHREADING
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
