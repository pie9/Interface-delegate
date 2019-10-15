using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Common
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) :
            base(3, length)
        { }     

        public override double GetArea()
        {
            var result = SideLength * SideLength * Math.Sqrt(3) / 4;
            OutboundResult("Triangle Area :", result);
            return result;
        }
    }
}
