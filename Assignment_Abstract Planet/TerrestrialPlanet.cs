﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Robin singh
 * Date: July 27 , 2017
 * Description: This is the abstract class of TerrestialPlanet that extended the planet abstract class
 * Version: 0.3-Implemented IHasMoons and IHabitable
 */
namespace Assignment_Abstract_Planet
{
    class TerrestrialPlanet : Planet,IHasMoons,IHabitable
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private bool _oxygen;

        //CONSTRUCTOR

        /// <summary>
        /// This is the main CONSTRUCTOR for the class TerrestrialPlanet.
        /// It takes four parameters - name(string) - diameter(double) - mass(double) - oxygen(bool).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
                : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
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

        public bool Habitable()
        {
            return _oxygen;
        }
    }
}
