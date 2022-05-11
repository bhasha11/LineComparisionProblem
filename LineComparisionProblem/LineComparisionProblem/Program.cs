using System;


namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            LineComparision lineCom = new LineComparision( 1,2,3,4);
            double length1=lineCom.LengthOfLine();
            LineComparision line = new LineComparision(1, 2, 3, 4);
            double length2 = line.LengthOfLine();
            if(length1.Equals(length2))
            {
                Console.WriteLine("Both Lines Are Equal");
            }
            else
            {
                Console.WriteLine(" Lines Are Not Equal");
            }
            Console.ReadKey();
        }
    }

}

