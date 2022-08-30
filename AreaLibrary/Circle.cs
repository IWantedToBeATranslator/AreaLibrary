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

        override public double Area()
        {
            if (FigParams.Count() == 0) throw new Exception("Not enough parameters to calculate the Circle area.");
            return FigParams[0] * FigParams[0] * Math.PI;
            
        }
    }
}
