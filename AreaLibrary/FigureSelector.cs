using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public static class FigureSelector
    {
        public static Figure Select(double[] data)
        {
            int Elements = data.Count();
            switch (Elements)
            {
                case 0:  throw new NullReferenceException();
                case 1:  return new Circle(data);
                case 2:  return new Rectangle(data);
                case 3:  return new Triangle(data);
                default: throw new NullReferenceException();
            }
        }
    }
}
