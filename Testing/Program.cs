using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {

            string FullName = Name("Chris", " Waisncott");
            Name("David", " Maz");

            Console.WriteLine(FullName);
            Console.ReadLine();
        }
       public static string Name(string A, string B)
        {
            return A + B;
            

        }
       
    }
    
}


