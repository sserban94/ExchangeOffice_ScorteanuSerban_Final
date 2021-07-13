using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice_ScorteanuSerban.Entities
{
    [Serializable]
    public class Currency
    {
        public string Coin { get; set; }

        public Currency()
        {
            
        }

        public Currency(string coin)
        {
            Coin = coin;
        }

        public override string ToString()
        {
            return Coin;
        }

        
    }

}
