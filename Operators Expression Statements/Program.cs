namespace Operators_Expression_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable decleration
            int x, a, b, y;
           

            //Assignment Operators
            x = 3;
            y = 2;

            //Mathematical Operators
            x = 3 + 4;
            y = 5 * 7;
            b = 10 / 5;
            a = (x + y) * (b - x);

            //if operators
            if  (x == y) 
            if (x > y) 
            if (x <= y) 

            //conditional and operator
            // This cannot be used in integers. The && operator says that both things must be equal.
            if ((x > y) && (a > b)) 
            {

            }

            //the or operator. This means that one has to be true for it to be true?
            if ((x <= y) || (a > b))
            {

            }
        }
    }
}
