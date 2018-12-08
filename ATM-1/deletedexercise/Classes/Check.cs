using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deletedexercise.Classes
{
    class Check
    {
        public static int StartSecim()
        {
            try { return int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Zehmet olmasa KARTI duzgun daxil edin");
                return StartSecim();
            }
        }

        public static int CheckPin()
        {
            try { return Int32.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Reqem daxil edin");
                return CheckPin();
            }
        }
    }
}
