using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            TestListaVaciaIngles();
            Console.WriteLine("---------------------------------------------------");
            TestListaVaciaAleman();
            Console.WriteLine("---------------------------------------------------");
            TestUnCuadradoAleman();

        }
        static void TestListaVaciaIngles(){

            ShapeComposite f = new ShapeComposite();
            Console.WriteLine("TestListaVaciaIngles");
            string listaVaciaIngles = "<h1>Empty list of shapes!</h1>";
            Console.WriteLine(listaVaciaIngles);
            Console.WriteLine(f.prettyPrint( new RenderIngles()));
            
        }
        static void TestListaVaciaAleman()
        {
            ShapeComposite f = new ShapeComposite();
            string listaVaciaAleman = "<h1>Lege lijst van vormen!</h1>";
            Console.WriteLine("TestListaVaciaAleman");
            Console.WriteLine(listaVaciaAleman);
            Console.WriteLine(f.prettyPrint(new RenderAleman()));
        }
        static void TestUnCuadradoAleman()
        {
            ShapeComposite f = new ShapeComposite();
            Console.WriteLine("TestUnCuadradoAleman");
            string test = "<h1>Samenvatting vormen</h1><br/>1 Vierkant Oppervlakte 1 Omtrek 4<br/>TOTAL:<br/>1 vormen Omtrek 4 Oppervlakte 1";

            f.addShape(ShapeFFactory.createSquare(1));
            Console.WriteLine(test);
            Console.WriteLine(f.prettyPrint(new RenderAleman()));

        }


    }
}
