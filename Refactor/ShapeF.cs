using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{

    interface IShape
    {
        double getArea();
        double getPerimeter();
    }

    public class ShapeComposite:IShape
    {
        private List<ShapeF> shapes { get; set; }



        public ShapeComposite()
        {
            shapes = new List<ShapeF>();
        }
        public double getArea()
        {
            return shapes.Sum(s => s.getArea());
        }

        public string prettyPrint(IRenderIdioma idioma)
        {
            StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(idioma.getH1(getShapeCount()));

            int numberSquares = this.getShapesTypeCount(ShapeType.SQUARE);
            int numberCircles = this.getShapesTypeCount(ShapeType.CIRCLE);
            int numberTriangles = this.getShapesTypeCount(ShapeType.EQUILATERAL_TRIANGLE);

            double areaSquares = this.getAreaType(ShapeType.SQUARE);
            double areaCircles = this.getAreaType(ShapeType.CIRCLE);
            double areaTriangles = this.getAreaType(ShapeType.EQUILATERAL_TRIANGLE);



            double perimeterSquares = this.getPerimeterType(ShapeType.SQUARE);
            double perimeterCircles = this.getPerimeterType(ShapeType.CIRCLE);
            double perimeterTriangles = this.getPerimeterType(ShapeType.EQUILATERAL_TRIANGLE);

            sb.Append(idioma.getLine(numberSquares, areaSquares, perimeterSquares, new TranslateSquare()));
            sb.Append(idioma.getLine(numberCircles, areaCircles, perimeterCircles, new TranslateCircle()));
            sb.Append(idioma.getLine(numberTriangles, areaTriangles, perimeterTriangles, new TranslateTriangle()));

            sb.Append(idioma.getFooter((numberSquares + numberCircles + numberTriangles), (areaSquares + areaCircles + areaTriangles), (perimeterSquares + perimeterCircles + perimeterTriangles)));


            return sb.ToString();


            

        }

        public int getShapesTypeCount(ShapeType st)
        {
            return shapes.Where(s => s.getType() == st.getType())
                   .Count();
        }
        public int getShapeCount()
        {
            return this.shapes.Count;
        }
        public double getPerimeter()
        {
            return shapes.Sum(s => s.getPerimeter());
        }

        public double getAreaType(ShapeType st)
        {
            return shapes.Where(s => s.getType() == st.getType())
                         .Sum(x => x.getArea());
        }

        public double getPerimeterType(ShapeType st)
        {
            return shapes.Where(s => s.getType() == st.getType())
                .Sum(x => x.getPerimeter());
        }

        public void addShape(ShapeF s)
        {
            shapes.Add(s);
        }
    }

    
    public class ShapeF:IShape
    {

        private readonly double width;
        private ShapeType type;

        public IMedidas MedidasStrategy { get; set; }


        public ShapeF(ShapeType type, double w)
        {
            this.type = type;
            this.width = w;
        }


        public int getType()
        {
            return this.type.getType();
        }

        public  double getArea(){
            return MedidasStrategy.getArea(this);
        }
        public double getPerimeter()
        {
            return MedidasStrategy.getPerimeter(this);
        }

       
        public double getWidth()
        {
            return this.width;
        }


      
    }

   
}
