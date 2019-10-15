namespace Interface.Common
{
    public abstract class AbstractRegularPolygon : IDelegateHandler
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        public ResultHandler ResultHandlerdelegate { get; set; }
        public OutboundResultHandler OutboundResult { get; set; }

        public AbstractRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;            
            ResultHandlerdelegate = GetPerimeter;
            ResultHandlerdelegate += GetArea;
        }

        public double GetPerimeter()
        {
            var result = NumberOfSides * SideLength;
            OutboundResult("Triangle Perimeter :", result);
            return result;
        }
        public abstract double GetArea();                          
    }
}
