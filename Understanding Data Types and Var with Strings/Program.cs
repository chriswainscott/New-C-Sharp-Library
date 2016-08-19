using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_Data_Types_and_Var_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Tyep your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();

            //You should initialize your date by doing the following
            // Console.WriteLine("Type your last name:");
            // string myLastName = Console.ReadLine();


            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
//This is C# fundamentals for Absolute Beginner @ Microsoft Virtual Academy, Great vidoes for beginners
