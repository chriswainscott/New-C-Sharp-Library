using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_Understanding_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our class! ");
            Console.Write("How are you doing in this class? ");
            string yourAnswer;
            yourAnswer = Console.ReadLine();

            Console.Write("Do you feel like you are learning stuff? ");
            string classValue = Console.ReadLine();


            Console.WriteLine("I know you will get better" + " " + "Find your way to study and work hard!");
            Console.WriteLine("The answers to the questions" + " " + "How are you doing in this class? " + " " +
                yourAnswer + "--- " + "Do you feel like you are learning stuff?" + " " + classValue);
            Console.ReadLine();

        }

    }
}
