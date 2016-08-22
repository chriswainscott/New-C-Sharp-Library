using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Understanding_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month is your birthday in? ");
            string birthMonth = Console.ReadLine();
            {
                Console.WriteLine("What day of the month is your Birthday? ");
                string birthDay = Console.ReadLine();
                {
                    Console.WriteLine("What Year were you born? ");
                    string birthYear = Console.ReadLine();

                    Console.WriteLine("So your full birthday is:" + " " + birthMonth + " " + birthDay + "," + " " + birthYear + ".");
                    Console.ReadLine();
                }
            }

        }
    }
}
