using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Circle : Figure
    {
        /// <summary>
        /// Creates a Circle object.
        /// </summary>
        /// <param name="data">An array, only the first element is used as radius. Cannot be null.</param>
        public Circle(double[] data)
        {
            FigParams = data;
        }

        /// <summary>
        /// Creates a Circle object.
        /// </summary>
        /// <param name="data">Circle radius. Cannot be null.</param>
        public Circle(double data)
        {
            FigParams = new double[] { data };
        }

        public double[] Data;

        /// <summary>
        /// Data of the Circle (its radius) stored as an array. Only the first element is ever used.
        /// </summary>
        public double[] FigParams { get => Data; set => Data = value; }

        /// <summary>
        /// Calculates an Area of the Circle: pi * R * R.
        /// </summary>
        /// <returns>Full Area.</returns>
        public double Area()
        {
            return FigParams[0] * FigParams[0] * Math.PI;
        }
    }
}
