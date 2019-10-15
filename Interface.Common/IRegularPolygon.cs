namespace Interface.Common
{
    interface IRegularPolygon 
    {
        int NoOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
