using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Understanding_Data_Types_and_Variables
{
    public class birthDay
    {
        public static void birthDate()
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
                   
                }
            }
        }
        public class birthMessage
        {
            public static void message()
            {
                Console.WriteLine("Dear New Employee");
                Console.WriteLine("We are happy to celebrate your birthday with you this year");
                Console.WriteLine("We have included a $300 gift card for Wal-mart");
                Console.WriteLine("Happy Birthday from your employer on your birthday of : ");

                Console.ReadLine();
            }
        }

        public static void Main(string[] args)
        {
            var birthDay = new birthDay();
            var message = new birthMessage();

            birthDay.birthDate();

        }


    }
}