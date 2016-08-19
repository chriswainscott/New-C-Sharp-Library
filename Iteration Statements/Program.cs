using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Statements
{
    //this code will put a list of numbers from 0 to 9 ( 10 numbers) down the left side of the console window.
    // we are initiailizing i to - then we will run that through ( by the increment operatior i++) until the
    // i<10 is true and stop when it is false. 
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
        
    }
}
// you could also change i to myValue  to do the same thing.
// for (int myValue = 0; myValue <12; myValue++)
//    {
//      Console.WriteLine(i);
//  }
//       Console.ReadLine();
//  }
// }
