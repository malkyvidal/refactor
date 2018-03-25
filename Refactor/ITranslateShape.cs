using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
   public interface ITranslateShape
    {
         
       string translateIngles(int nroShapes);
       string translateAleman(int nroShapes);
    }

    public class TranslateSquare:ITranslateShape {

        

        public string translateIngles(int nroShapes)
        {
            return nroShapes == 1 ? "Square" : "Squares";
        }

        public string translateAleman(int nroShapes)
        {
            return nroShapes == 1 ? "Vierkant" : "Vierkanten";
        }

        
    }

    public class TranslateCircle : ITranslateShape
    {

        public string translateIngles(int nroShapes)
        {
            return nroShapes == 1 ? "Circle" : "Circles";
        }

        public string translateAleman(int nroShapes)
        {
            return nroShapes == 1 ? "Cirkel" : "Cirkels";
        }
    }

    public class TranslateTriangle : ITranslateShape
    {

        public string translateIngles(int nroShapes)
        {
            return nroShapes == 1 ? "Triangle" : "Triangles";
        }

        public string translateAleman(int nroShapes)
        {
            return nroShapes == 1 ? "Driehoek" : "Driehoeken";
        }
    }
}
