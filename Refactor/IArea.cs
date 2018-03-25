using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    public interface IMedidas
    {
        double getArea(ShapeF s);
        double getPerimeter(ShapeF s);
    }



    public class SquareMedidas:IMedidas{

        public double getArea(ShapeF s)
        {
            var w = s.getWidth();
            return w * w;
        }

        public double getPerimeter(ShapeF s)
        {
            return 4 * s.getWidth();
        }
    }


    public class CircleMedidas : IMedidas
    {

        public double getArea(ShapeF s)
        {
            return Math.PI * (s.getWidth() / 2) * (s.getWidth() / 2);
        }

        public double getPerimeter(ShapeF s)
        {
            return  Math.PI * s.getWidth();
        }
    }


    public class TriangleMedidas : IMedidas
    {

        public double getArea(ShapeF s)
        {
            var width = s.getWidth();
            return (Math.Sqrt(3) / 4) * width * width;
        }

        public double getPerimeter(ShapeF s)
        {
            var width = s.getWidth();
            return 3 * width;
            
        }
    }
}
