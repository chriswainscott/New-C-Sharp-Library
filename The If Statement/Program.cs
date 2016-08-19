using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = "";
            if (userValue == "1")
                 message = "You won a new car!";
            else if (userValue == "2")
                 message = " you won a new boat!";
            else if (userValue == "3")
                 message = " You won a new cat";
            else
            {
                 message = "Sorry we didnt understand!";
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
//This is C# fundamentals for Absolute Beginner @ Microsoft Virtual Academy, Great vidoes for beginners