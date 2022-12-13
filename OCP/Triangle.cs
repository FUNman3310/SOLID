using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Triangle : Shape
    {
        double Width { get; set; }
        double Height { get; set; }

        public override double Area()
        {
            return (Width * Height)/2;
        }
    }
}
