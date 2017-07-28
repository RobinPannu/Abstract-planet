using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Robin singh
 * Date: July 12, 2017
 * Description: This is the abstract class of GiantPlanet that extended the planet abstract class
 * implement the IHasMoons and IHasRings
 * Version: 0.2- Implemented IHasMoons and IHasRings
 */
namespace Assignment_Abstract_Planet

{
    class GiantPlanet : Planet,IHasMoons,IHasRings
    { // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _type;


        //CONSTRUCTOR

        /// <summary>
        /// This is the main CONSTRUCTOR for the class GiantPlanet.
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


        //PUBLIC METHODS
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
