using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Robin singh
 * Date: July 27, 2017
 * Description: This is the program class
 * Version: 0.3 - Print Giant Planet and terrestrialplanet
 */
namespace Assignment_Abstract_Planet
{

    class Program
    {
        static void Main(string[] args)
        {
         
            GiantPlanet giantPlanet = new GiantPlanet("Jupitor", 54000, Convert.ToDouble(1.898 * Math.Pow(10, 38)), "Gas");

            //show GiantPlanet object to the console
            Console.WriteLine(giantPlanet.ToString());
          
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 7300, Convert.ToDouble(5.972 * Math.Pow(10, 34)), true);

            //Printed terrestrialPlanet object to the console
            Console.WriteLine(terrestrialPlanet.ToString());

            Console.ReadKey();
        }
    }
}
