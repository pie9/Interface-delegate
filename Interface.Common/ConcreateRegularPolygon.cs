using System;

namespace Interface.Common
{
    public class ConcreateRegularPolygon : IDelegateHandler
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        public ResultHandler ResultHandlerdelegate { get; set;}
        public OutboundResultHandler OutboundResult { get; set; }

        public ConcreateRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
            ResultHandlerdelegate = GetPerimeter;
            ResultHandlerdelegate += GetArea;
        }

        public double GetPerimeter()
        {
            var result = NumberOfSides * SideLength;
            OutboundResult("Square Perimeter :", result);
            return result;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
