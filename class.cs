// Original code https://www.tutorialspoint.com/csharp/csharp_classes.htm

using System;

namespace BoxApp {

	class Box {
		
		public double length;   // Lenght of a box
		public double height;   // Height of a box
		public double breadth;  // Breadth of a box

	}
	
	class BoxTester {
	
		static void Main() {
		
			Box Box1 = new Box();   // Declare Box1 of type Box
			Box Box2 = new Box();   // Declare Box2 of type Box
			double volume = 0.0;    // Store the volume of a Box.
			
			// Box1 specification
			Box1.length = 6.0;
			Box1.height = 6.0;
			Box1.breadth = 7.0;
			
			// box2 specification
			Box2.length = 12.0;
			Box2.height = 10.0;
			Box2.breadth = 13.0;
			
			// volume of Box1
			volume = Box1.length * Box1.height * Box1.breadth;
			Console.WriteLine("Volume of Box1: {0}", volume);
			
			// volume of Box2
			volume = Box2.length * Box2.height * Box2.breadth;
			Console.WriteLine("Volume of Box2: {0}", volume);
			Console.ReadKey();
		
		}
	
	}

}
