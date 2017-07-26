using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Robin singh
 * Date: July 12, 2017
 * Description: This is the abstract class of GiantPlanet
 * Version: 0.1- Created PRIVATE INSTANCE VARIABLES and CONSTRUCTOR CLASS
 */
namespace Assignment_Abstract_Planet
{
    class GiantPlanet : Planet
    { // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _type;


        //CONSTRUCTOR

        /// <summary>
        /// This is the main constructor for the GiantPlanet class.
        /// It takes four parameters - name(string) - diameter(double) - mass(double) - type(string).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type)
                : base(name, diameter, mass)
        {
            this._type = type;
        }

        

    }
}
