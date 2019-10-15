using Interface.Common;
using System;

namespace Interface
{
    public class Octagon : IRegularPolygon, IDelegateHandler
    {
        public int NoOfSides { get; set; }
        public int SideLength { get; set; }
        public ResultHandler ResultHandlerdelegate { get; set; }
        public OutboundResultHandler OutboundResult { get; set; }

        public Octagon(int length)
        {
            NoOfSides = 8;
            SideLength = length;
            ResultHandlerdelegate = GetArea;
            ResultHandlerdelegate += GetPerimeter;
        }

        public double GetArea()
        {
            var result = SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
            OutboundResult("Octagon Area :", result);
            return result;
        }

        public double GetPerimeter()
        {
            var result = NoOfSides * SideLength;
            OutboundResult("Octagon Perimeter :", result);
            return result;
        }
    }
}