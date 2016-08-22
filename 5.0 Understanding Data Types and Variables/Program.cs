using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_Understanding_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* commented this out to show another example
              
             
            int x; // this is declaring a variable
            int y;

            x = 7; // the = sign means to assign, so this means take 7 and assign it to x
            y = x + 3;// this takes the x value(7) adds it to 3 then places it in the y bucket

            Console.WriteLine(y);//this is asking for the y value which is 10 after the math previous
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");//WriteLine prints on the screen then goes to the next line
            Console.Write("Type your first name: ");//Write prints on the screen then waits for your response
            string myFirstName;//holding enough space for a string in the memory
            myFirstName = Console.ReadLine();//ReadLine is pulling the info you typed in and assigning (=) it to the name myFirstName

            /*
            string myLastName;
            Console.WriteLine("Type your last name: ");
            myLastName = Console.ReadLine();//this is stopping it to get the info typed in and assigning it to myLastName varible
            */
            // this is a quicker way to write the last 3 lines of code in 2 lines of code
            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine(); // this is called initialization. If possible decalre them as you need them and initialize them immediately if you can.

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
