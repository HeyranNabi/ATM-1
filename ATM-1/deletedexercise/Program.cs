using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deletedexercise.Classes;
namespace deletedexercise
{

    class Program
    {

        static void Main(string[] args)
        {
        //    Random r = new Random();


            List<Card> listofcards = new List<Card>
            {
                new Card("Ahmad", 12445678, 4444444, 780.90),
                new Card("Ali", 12345338, 4444554, 670.90),
                new Card("Leyla", 12365678, 4466444, 980.90),
                new Card("Fidan", 12377678, 4477444, 520.90),
                new Card("Nermin", 12295678, 4884444, 450.90)
            };

            List<User> listofusers = new List<User>
            {
                new User("Ahmad", "Aliyev", listofcards[0]),
                new User("Ali", "Memmedov", listofcards[1]),
                new User("Leyla", "Quliyeva", listofcards[2]),
                new User("Fidan", "Aliyeva", listofcards[3]),
                new User("Narmin", "Muradova", listofcards[4])
            };

        //    for (int i = 0; i < listofcards.Count; i++)
        //    {
        //        Console.WriteLine([i]);
        //}

        Console.WriteLine("Xosh gelmishsiniz");
            Console.WriteLine("Kartinizi daxil edin");

            var cardNumber = Convert.ToInt32(Console.ReadLine());

           if (listofcards.Exists(l => l.Cardnumber == cardNumber))
           {

                Console.WriteLine("Ashagidaki emeliyyatlardan birini sechin");
                Console.WriteLine("1.Balansi yoxlamaq");
                Console.WriteLine("2.Pul daxil etmek");
                Console.WriteLine("3.Pul chixarmaq");
           }
           else
           {
                Console.WriteLine("Daxil etdiyiniz kart yanlishdir");
           }


            var input = Convert.ToInt32(Console.ReadLine());


            ////var checkcardnumber1=listofcards.

            var checkNumber1 = listofcards.FirstOrDefault(f => f.Cardnumber == cardNumber);
            if (input == 1)
            {
               // var checkNumber1 = listofcards.FirstOrDefault(f=>f.Cardnumber==cardNumber);
                var amount1 = checkNumber1.Balance;


                Console.WriteLine("Sizin balansiniz " + amount1 + " AZN teshkil edir");
            }
            else if (input == 2)
            {
                Console.WriteLine("Pulu daxil edin");

         
                    var inputamount = Convert.ToInt32(Console.ReadLine());
                   // var checkNumber2 = listofcards.FirstOrDefault(f => f.Cardnumber == cardNumber);

                var func1 = checkNumber1.addbalance(inputamount);

                    Console.WriteLine("Mebleg hesabiniza yuklendi");
                    Console.WriteLine("Hesabinizda hazirki mebleg " + checkNumber1.Balance + " AZN teshkil edir");


                

            }

            else if (input == 3)
            {
                Console.WriteLine("Chixaracaginiz meblegi daxil edin");
                var outputamount = Convert.ToInt32(Console.ReadLine());
             //   var checkNumber3 = listofcards.FirstOrDefault(f => f.Cardnumber == cardNumber);
                var func2 = checkNumber1.outbalance(outputamount);

                Console.WriteLine("Hesabinizdan " + outputamount + " AZN mebleg chixarildi");
                Console.WriteLine("Hesabinizda hazirki mebleg " + checkNumber1.Balance + " AZN teshkil edir");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz reqem yanlishdir");
            }

        }
    }
}
