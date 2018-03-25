using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
   public interface IRenderIdioma
    {
      string getH1(int numeroDeShapes);
      string getLine(int numberShapes, double area, double perimeter, ITranslateShape ts);
      string getFooter(int numberShapes, double area, double perimeter);
    }

   public class RenderIngles : IRenderIdioma
   {

       public string getH1(int numeroDeShapes)
       {
           if (numeroDeShapes==0)
           {
               return "<h1>Empty list of shapes!</h1>"; ;
           }
           return "<h1>Shapes report</h1><br/>";
       }


       public string getLine(int numberShapes, double area, double perimeter, ITranslateShape ts)
       {
           if (numberShapes > 0)
           {
                return numberShapes + " " + ts.translateIngles(numberShapes) + " Area " + area.ToString("#.##") +
                           " Perimeter " + perimeter.ToString("#.##") + "<br/>";
           }
           return "";
       }


       public string getFooter(int numberShapes, double area, double perimeter)
       {
           if (numberShapes > 0)
           {
               string returnString = string.Empty;
               returnString += "TOTAL:<br/>";
               returnString += (numberShapes) + " " + "shapes";
               returnString += "Perimeter " + (perimeter).ToString("#.##") + " ";
               returnString += "Area " + (area).ToString("#.##");
               return returnString;
           }

           return "";
       }
   }

   public class RenderAleman : IRenderIdioma
   {

       public string getH1(int numeroDeShapes)
       {

           if (numeroDeShapes == 0)
           {
               return "<h1>Lege lijst van vormen!</h1>";
           }
           return "<h1>Samenvatting vormen</h1><br/>";
       }


       public string getLine(int numberShapes, double area, double perimeter, ITranslateShape ts)
       {
           if (numberShapes > 0)
           {
               return numberShapes + " " + ts.translateAleman(numberShapes) + " Oppervlakte " + area.ToString("#.##") +
                       " Omtrek " + perimeter.ToString("#.##") + "<br/>";
            }
           
           return "";
       }


       public string getFooter(int numberShapes, double area, double perimeter)
       {
           if (numberShapes > 0)
           {
               string returnString = string.Empty;
               returnString += "TOTAL:<br/>";
               returnString += numberShapes + " " + "vormen" + " ";
               returnString += "Omtrek " + perimeter.ToString("#.##") + " ";
               returnString += ("Oppervlakte ") + area.ToString("#.##");
               return returnString;
           }
           return "";
           
       }
   }
}
