using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Arrays
{
    class Program
    {
        //Arrays are a collection of data that is usually related to each other. 

        int[] kidsAge = { 4, 7, 13, 15, 16 }; //this declares and initializes that this array has 5 values
        int[] boysClubAge = new int[5]; // this is to declare there are 5 unknown values that can pass into the new int

        
        public void Main(string[] args)
        {
            kidsAge[2] = 14;  // this changes the number 13 to 14 ( the 5 numbers start at 0 counting over so 13 is the 2nd array)
            kidsAge[3] = kidsAge[3] + 20; // this would be 15 + 20 = 35
        }
    }
}
