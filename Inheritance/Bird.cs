using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public string Size { get; set; }
		public string Color { get; set; }
		public string EatsWhat { get; set; }
		public bool CanFly { get; set; }

        public void PrintBirdDetails()
        {
            Console.WriteLine($"Has fur: {HasFur}");
			Console.WriteLine($"How many legs: {Legs}");
			Console.WriteLine($"How big: {Size}");
			Console.WriteLine($"What color: {Color}");
			Console.WriteLine($"What does it eat: {EatsWhat}");
			Console.WriteLine($"Can it fly: {CanFly}");
			Console.WriteLine();

        }
    }
}

