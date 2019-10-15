using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Common
{
    public class Square : ConcreateRegularPolygon
    {
        public Square(int length) :
            base(4, length)
        { }

        public override double GetArea()
        {
            var result = SideLength * SideLength;
            OutboundResult("Square Area :",result);
            return result;
        }
    }
}
