using System;


namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            LineComparision LineCom = new LineComparision( 1,2,3,4);
            LineCom.LengthOfLine();
            Console.ReadKey();
        }
    }

}

