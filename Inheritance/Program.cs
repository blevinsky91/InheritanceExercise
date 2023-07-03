using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - DONE 
            // give this class 4 members that all Animals have in common


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile - DONE
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class - DONE
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird bird1 = new Bird();

            bird1.HasFur = false;
            bird1.Legs = 2;
            bird1.Size = "6 inches";
            bird1.Color = "Red and Green";
            bird1.EatsWhat = "Worms";
            bird1.CanFly = true;

            bird1.PrintBirdDetails();


            /*Create an object of your Reptile class - DONE
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile rep1 = new Reptile();

            rep1.HasFur = false;
            rep1.Legs = 4;
            rep1.IsVenomous = true;
            rep1.Length = "4 feet long";
            rep1.HasScales = true;
            rep1.HasLongTongue = true;

            rep1.PrintReptileDetails();
        }
    }
}
