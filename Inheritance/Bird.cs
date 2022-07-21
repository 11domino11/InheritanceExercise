using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }
        public Bird(bool canFly, bool canSwim, double height, double weight)
        {
            CanFly = canFly;
            CanSwim = canSwim;
            Height = height;
            Weight = weight;
        }
        public bool CanFly { get; set; }
        public bool CanSwim { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
