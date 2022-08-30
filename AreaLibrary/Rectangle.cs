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

        private double[] Data;

        public double[] FigParams { get => Data; set => Data = value; }

        public double Area()
        {
            return FigParams[0] * FigParams[1];
        }

        public bool IsSquare()
        {
            return double.Equals(FigParams[0], FigParams[1]);
        }
    }
}
