using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Robin singh
 * Date: July 12, 2017
 * Description: This is the abstract class of planet
 * Version: 0.2- Created Constructor and public override
 */
namespace Assignment_Abstract_Planet
{

    // <summary>
    // This is the Planet Abstract class
    // </summary>

    public abstract class Planet
    {
        // PRIVATE FIELD (INSTANCE VARIABLES)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES
        public double Diameter
        {


            get
            {
                return _diameter;
            }

        }

        public double Mass
        {
            get

            {
                return _mass;
            }

        }
        public int MoonCount
        {
            get

            {
                return _moonCount;
            }
            set
            {
                MoonCount = value;
            }

        }
        public string Name
        {
            get

            {
                return _name;
            }

        }
        public double OrbitalPeriod
        {
            get

            {
                return _orbitalPeriod;
            }
            set
            {
                OrbitalPeriod = value;
            }

        }
        public int RingCount
        {
            get

            {
                return _ringCount;
            }
            set
            {
               RingCount = value;
            }

        }
        public double RotationPeriod
        {
            get

            {
                return _rotationPeriod;
            }
            set
            {
                RotationPeriod = value;
            }

        }
        //
        //CONSTRUCTOR
         
        public Planet(string name,double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // PUBLIC OVERRIDE METHODS

        /// <SUMMARY>
        /// OVERRIDDEN THE BUILT-IN ToString Method
        /// </SUMMARY>
        /// <return>
        /// string
        /// </return>

        public override string ToString()
        {
            string outputString = "";

            outputString = "Name" + Name + "\n" + "Diameter" + Diameter + "/n" + "Mass" + Mass + "/n";
            return outputString;
        }
      }
    }
