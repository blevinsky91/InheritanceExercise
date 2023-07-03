using System;
using System.Drawing;

namespace Inheritance
{
	public class Reptile : Animal
	{
		public string Length { get; set; }
		public bool IsVenomous { get; set; }
		public bool HasScales { get; set; }
		public bool HasLongTongue { get; set; }

        public void PrintReptileDetails()
        {
            Console.WriteLine($"Has fur: {HasFur}");
            Console.WriteLine($"How many legs: {Legs}");
            Console.WriteLine($"Is it venomous: {IsVenomous}");
            Console.WriteLine($"How long: {Length}");
            Console.WriteLine($"Does it have scales: {HasScales}");
            Console.WriteLine($"Does it have a long tongue: {HasLongTongue}");
            Console.WriteLine();

        }
    }
}

