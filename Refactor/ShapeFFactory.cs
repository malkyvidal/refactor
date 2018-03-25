using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
   public class ShapeFFactory
    {
       public static ShapeF createSquare(double width)
       {
           return new ShapeF(ShapeType.SQUARE, width) { MedidasStrategy = new SquareMedidas { } };
       }

       public static ShapeF createCircle(double width)
       {
           return new ShapeF(ShapeType.CIRCLE, width) { MedidasStrategy = new CircleMedidas { } };
       }

       public static ShapeF createTriangle(double width){
           return new ShapeF(ShapeType.EQUILATERAL_TRIANGLE,width){MedidasStrategy = new TriangleMedidas{}};
       }
    }
}
