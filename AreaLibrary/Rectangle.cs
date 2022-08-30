using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Rectangle : Figure
    {
        /// <summary>
        /// Creates a Rectangle object. This includes squares.
        /// </summary>
        /// <param name="data">An array, first two elements are used as rectangle sides. Cannot be null.</param>
        public Rectangle(double[] data)
        {
            FigParams = data;
        }

        /// <summary>
        /// Creates a Rectangle object. This includes squares.
        /// </summary>
        /// <param name="data">Two elements used as rectangle sides. Cannot be null.</param>
        public Rectangle(double A, double B)
        {
            FigParams = new double[] { A, B };
        }

        override public double Area()
        {
            if (FigParams.Count() < 2) throw new Exception("Not enough parameters to calculate the Rectangle area.");
            return FigParams[0] * FigParams[1];
        }

        public bool IsSquare()
        {
            if (FigParams.Count() < 2) throw new Exception("Not enough parameters to determine the Square.");
            return double.Equals(FigParams[0], FigParams[1]);
        }
    }
}
