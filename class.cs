// Original code https://www.tutorialspoint.com/csharp/csharp_classes.htm
// Modified by MD. Mehedi Hasan

using System;

namespace BoxApp {

	class Box {
		
		public double length;   // Lenght of a box
		public double height;   // Height of a box
		public double breadth;  // Breadth of a box
		public double volume;   // Volume of a box
	}
	
	class BoxTester {
	
		static void Main() {

			Box Box1 = new Box();   // Declare Box1 of type Box
			Box Box2 = new Box();   // Declare Box2 of type Box
			

			// Box1 specifications

			Box1.length = 5.0;
			Box1.height = 6.0;
			Box1.breadth = 7.0;
			Box1.volume = Box1.length * Box1.height * Box1.breadth;

			Console.WriteLine("Volume of Box1: {0}", Box1.volume);  // Print the volume of Box1
			

			// box2 specifications

			Box2.length = 12.0;
			Box2.height = 10.0;
			Box2.breadth = 13.0;
			Box2.volume = Box2.length * Box2.height * Box2.breadth;
			
			Console.WriteLine("Volume of Box2: {0}", Box2.volume);  // Print the volume of Box2
			Console.ReadKey();
		
		}
	
	}

}
