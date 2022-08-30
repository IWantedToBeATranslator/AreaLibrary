using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public interface Figure
    {
        public double Area();
        public double[] FigParams { get; set; }
    }
}