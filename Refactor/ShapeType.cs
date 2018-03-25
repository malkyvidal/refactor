using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    public class ShapeType
    {
        private int type;

        public static readonly ShapeType CIRCLE = new ShapeType(2);
        public static readonly ShapeType SQUARE = new ShapeType(1);
        public static readonly ShapeType EQUILATERAL_TRIANGLE = new ShapeType(3);


        private ShapeType(int tipo)
        {
            this.type = tipo;
        }

        public int getType()
        {
            return type;
        }

    }
}
