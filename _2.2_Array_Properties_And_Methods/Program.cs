using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Array_Properties_And_Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declaring the variables in the array
            int[] userAge = { 3, 5, 8, 19, 256 };  //using the length method
            
            //initiating and allocating the student array
            int[] student = new int[5];

            //Copy the source to the student.
            Array.Copy(userAge, student, 5);  //using the copy method()

            //print out how many array values there are in the console window.
            Console.WriteLine("The length of students Seats array is: " + userAge.Length);
            
            //Display the student array in the console window.
            Console.WriteLine("---Target array---");
            foreach (int value in student)
            {
                Console.WriteLine(value);
            }

                //stop the program from disappearing from the screen. Forcing the user to press a button to go finish.
                Console.ReadLine();
        }

            //You can also use the sort() method to put arrays in an order.
            //The Indexof() method will determine if a certain value exist in an array.  Array.IndexOf(studetns, 5);
    }
}