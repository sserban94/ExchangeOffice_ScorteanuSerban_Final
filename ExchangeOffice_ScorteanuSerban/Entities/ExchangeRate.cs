using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice_ScorteanuSerban.Entities
{
    [Serializable]
    public class ExchangeRate
    {
        public string ConversionName { get; set; }
        public string OperatorType { get; set; }
        public double Rate { get; set; }
        public DateTime CheckedRateDay { get; set; }

        public ExchangeRate()
        {
            //EuroDollarRate = 0;   // value types initialized with 0 by default 
            //EuroToLeiRate = 0;
            //DollarToLeiRate = 0;
        }

        public ExchangeRate(string conversionName, string operatorType, double rate, DateTime checkedRateDay)
        {
            ConversionName = conversionName;
            OperatorType = operatorType;
            Rate = rate;         
            CheckedRateDay = checkedRateDay;
        }

        public override string ToString()
        {
            return ($"Type_of_Conversion: {ConversionName}    Conversion_Rate:{Rate}    Rate_updated_on:{CheckedRateDay.ToShortDateString()}    ||{OperatorType}|| ");
        }
    }
}
