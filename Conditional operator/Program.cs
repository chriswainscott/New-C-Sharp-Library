using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            //is value typed in = to 1, if so then the first word after ? gets assigned to "message" if false and not = 1 then the words after the : get assigned to message

            string message = (userValue == "1") ? "boat" : "strand of lint ";

            Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");

            // you could also use the following instead of lines 21-23
            // Console.WriteLine("You won a {0}.", message);
            //Outputs: "You won a boat."

            //if you were giving back 2 variables you do as follow
            // Console.WriteLIne("You entered: {0}, therefore you won a {1}.", userValue, message);
            //outputs: "You entered 1, therefore you won a boat."
            Console.ReadLine();


        }
    }
}
//This is C# fundamentals for Absolute Beginner @ Microsoft Virtual Academy, Great vidoes for beginners