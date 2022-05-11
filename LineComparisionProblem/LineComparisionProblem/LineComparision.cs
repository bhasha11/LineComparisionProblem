using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    internal class LineComparision
    {
        public int X_One, X_Two, Y_One, Y_Two;
        public LineComparision(int X_One,int X_Two, int Y_One,int Y_Two)
        { 
            this.X_One = X_One;
            this.X_Two = X_Two;
            this.Y_One = Y_One;
            this.Y_Two = Y_Two;

        }
        public void LengthOfLine()
        {
            double LengthOfXY = Math.Sqrt(Math.Pow((X_Two - X_One), 2) + Math.Pow((Y_Two - Y_One), 2));
            Console.WriteLine("Length of Value 1 is:: " + LengthOfXY);
           

        }
    }
}
    

