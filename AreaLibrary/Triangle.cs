using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Creates a Triangle object.
        /// </summary>
        /// <param name="data">An array, first three elements are used as triangle sides. Cannot be null.</param>
        public Triangle(double[] data)
        {
            FigParams = data;
        }

        /// <summary>
        /// Creates a Triangle object.
        /// </summary>
        /// <param name="data">Three elements used as triangle sides. Cannot be null.</param>
        public Triangle(double A, double B, double C)
        {
            FigParams = new double[] {A, B, C};
        }

        override public double Area()
        {
            if (FigParams.Count() < 3) throw new Exception("Not enough parameters to calculate the Triangle area.");
            double SemiP = (FigParams[0] + FigParams[1] + FigParams[2]) / 2;
            return Math.Sqrt(SemiP * (SemiP - FigParams[0]) * (SemiP - FigParams[1]) * (SemiP - FigParams[2]));
        }

        public bool IsRight()
        {
            if (FigParams.Count() < 3) throw new Exception("Not enough parameters to determine the Triangle.");
            double Side1, Side2, Hypothenuse;
            if (FigParams[0] > FigParams[1])
            {
                Side1 = FigParams[1];
                if (FigParams[0] > FigParams[2])
                {
                    Side2 = FigParams[2];
                    Hypothenuse = FigParams[0];
                }
                else
                {
                    Side2 = FigParams[0];
                    Hypothenuse = FigParams[2];
                }
            }
            else
            {
                Side1 = FigParams[0];
                if (FigParams[1] > FigParams[2])
                {
                    Side2 = FigParams[2];
                    Hypothenuse = FigParams[1];
                }
                else
                {
                    Side2 = FigParams[1];
                    Hypothenuse = FigParams[2];
                }
            }

            return double.Equals(Hypothenuse * Hypothenuse, Side1 * Side1 + Side2 * Side2);
        }
    }
}
