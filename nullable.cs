// Programmed by MD. Mehedi Hasan

using System;

namespace NullApp {

	class NullProgram {

		static void Main() {

			int? number_one = null;
			int? number_two = 66;

			double? number_three = null;
			double? number_four = 56.64;
		
			bool? bool_one = true;
			bool? bool_two = false;

			Console.WriteLine("Nullables: {0}, {1}, {2}, {3}, {4}, {5}", number_one, number_two, number_three, number_four, bool_one, bool_two);
			Console.ReadLine();		
		}
	}
}
