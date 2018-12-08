using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deletedexercise.Classes
{
    class Transaction
    {
        public string Amount { get; set; }
        public int Cardnumber { get; set; }

        public Transaction(string _amount, int _cardnumber)
        {
            Amount = _amount;
            Cardnumber = _cardnumber;
        }
    }
}
