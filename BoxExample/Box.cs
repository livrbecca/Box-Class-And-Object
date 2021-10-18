
using System;
using System.Collections.Generic;
using System.Text;

namespace YTCC1
{
    class Box // creating a data type that looks like a box
    {
        public double Length { get; set; }
        // properties of classes should get capital letters
        // get, allows you to retrieve the value. set, allows you to set a value
        // short cut: prop then tab x2
        // if you removed set you would get an error, when try tring to assign a value - would be read only / retrieve only
        // if you only had set & not get: error wehn trying to Console.WriteLine it, you can set it but you cannot retrieve it
        public double Breadth { get; set; }
        public double Height { get; set; }


        // inside of Box class: method to calculate volume


        public double getVolume()
        // doesnt need to take params because its part of the class that already contains the properties
        {
            return Length * Breadth * Height;
        }

        public double getArea()
        // doesnt need to take params because its part of the class that already contains the properties
        {
            return Length * Breadth;
        }
    }
}