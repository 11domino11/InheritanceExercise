using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird condor = new Bird(true, false, 9.5, 20);
            condor.Name = "Condor";
            condor.Habitat = "Forest";
            condor.Diet = "large dead wildlife";
            condor.IsExtinct = false;

            Console.WriteLine($"{condor.Name} is a  bird that can fly, can't swim, has a {condor.Height} foot wingspan, and {condor.Weight} lbs. Live in {condor.Habitat}, and eats {condor.Diet}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile beardedDragon = new Reptile(4, 20, true, true);
            beardedDragon.Name = "Bearded Dragon";
            beardedDragon.Habitat = "Rocky Desert";
            beardedDragon.IsExtinct= false;

            Console.WriteLine($"The {beardedDragon.Name} lives in {beardedDragon.Habitat} eats meat and plants, and is usually around {beardedDragon.Width} inches wide and {beardedDragon.Length} inches long");
        }
    }
}
