using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }
        public Reptile(double width, double length, bool meatEater, bool plantEater)
        {
            Width = width;
            Length = length;
            MeatEater = meatEater;
            PlantEater = plantEater;
        }
        public double Width { get; set; }
        public double Length { get; set; }
        public bool MeatEater { get; set; }
        public bool PlantEater { get; set; }



    }
}
