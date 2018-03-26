// Original code https://www.tutorialspoint.com/csharp/csharp_classes.htm
// Modified by MD. Mehedi Hasan

using System;

namespace BoxApp {

	class Box {
		
		public double length;   // Lenght of a box
		public double height;   // Height of a box
		public double breadth;  // Breadth of a box

	}
	
	class BoxTester {
	
		static void Main() {

			double length, height, breadth, volume;
		
			Box Box1 = new Box();   // Declare Box1 of type Box
			Box Box2 = new Box();   // Declare Box2 of type Box
			

			// Box1 specifications

			length = Box1.length = 5.0;
			height = Box1.height = 6.0;
			breadth = Box1.breadth = 7.0;
			volume = length * height * breadth;

			Console.WriteLine("Volume of Box1: {0}", volume);  // Print the volume of Box1
			

			// box2 specifications

			length = Box2.length = 12.0;
			height = Box2.height = 10.0;
			breadth = Box2.breadth = 13.0;
			volume = length * height * breadth;
			
			Console.WriteLine("Volume of Box2: {0}", volume);  // Print the volume of Box2
			//Console.ReadKey();
			long memory = GC.GetTotalMemory(true);
			Console.WriteLine(memory);
		
		}
	
	}

}
