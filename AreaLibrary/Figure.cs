using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public partial class Figure
    {
        public double[] Data;
        public double[] FigParams
        {
            get
            {
                return Data;
            }
            set
            {
                bool check = true;
                foreach (double v in value)
                {
                    if (v <= 0) check = false;
                }
                if (check) Data = value;
                else throw new NullReferenceException();
            }
        }

        virtual public double Area() { return 0; }
    }
}