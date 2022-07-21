using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {

        }
        public Animal(string name, string habitat, string diet, bool isExtinct)
        {
            Name = name;
            Habitat = habitat;
            Diet = diet;
            IsExtinct = isExtinct;
            
        }
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public bool IsExtinct { get; set; }
        
        
    }
}
