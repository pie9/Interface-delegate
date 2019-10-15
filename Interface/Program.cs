using Interface.Common;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            square.OutboundResult += OnOutbountEvent;
            square.ResultHandlerdelegate();            

            var triangle = new Triangle(5);
            triangle.OutboundResult += OnOutbountEvent;
            triangle.ResultHandlerdelegate();       

            var octagon = new Octagon(5);
            octagon.OutboundResult = OnOutbountEvent;
            octagon.ResultHandlerdelegate();
           
            Console.ReadKey();
        }

        //public static void GeoType(dynamic type)
        //{            
        //    type.GetArea();
        //    type.GetPerimeter();
        //}

        public static void OnOutbountEvent(string type, double result)
        {
            Console.WriteLine(type + " " + result);
        }       
    }
}
