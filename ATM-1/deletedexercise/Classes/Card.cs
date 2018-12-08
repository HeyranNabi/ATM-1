using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deletedexercise.Classes
{
  public class Card
    {
        public string CardHolderName { get; set; }
        public int Pinnumber { get; set; }
        public int Cardnumber { get; set; }
        public double Balance { get; set; }

        public Card(string _cardholdername, int _pinnumber, int _cardnumber, double _balance)
        {
            CardHolderName = _cardholdername;
            Pinnumber = _pinnumber;
            Cardnumber = _cardnumber;
            Balance = _balance;
        }

        public string addbalance(double mebleg)
        {
            Balance += mebleg;
            return "pul qoyuldu";
        }
        public string outbalance(double mebleg)
        {
            if (mebleg < 1000)

            {
                Balance -= mebleg;
                return "pul chixarildi";
            }
            else
            {
                return "Chekilen mebleg 1000 AZN-den yuxari olmamalidir";
            }
        }
    }
}
