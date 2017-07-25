using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Robin singh
 * Date: July 12, 2017
 * Description: This is the abstract class of planet
 * Version: 0.1- Created planet class
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

    }
}
