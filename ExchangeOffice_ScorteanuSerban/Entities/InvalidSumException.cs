using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice_ScorteanuSerban.Entities
{
    class InvalidSumException : Exception
    {
        public double InitialSum { get; set; }

        public InvalidSumException(double initialSum)
        {
            InitialSum = initialSum;
        }

        public override string Message
        {
            get
            {
                return "The initial sum value " + InitialSum + " is invalid";
            }
        }
    }
}
