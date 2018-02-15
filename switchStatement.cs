// programmed by MD. Mehedi Hasan.

using System;

namespace SwitchApplication {
	class Switch_statement {
		
		static void Main() {
			
			Console.WriteLine("Today is: SAT /SUN /MON /TUE /WED /THU /FRI ?");
			string day = Console.ReadLine();
			
			switch(day) {

				case "SAT":
				case "SUN":
				case "MON":
				case "TUE":
				case "WED":
				case "THU":
					Console.WriteLine("Go to your class !");
					break;

				case "FRI":
					Console.WriteLine("Eat.Code.Sleep");
					break;

					default:
				Console.WriteLine("Invalid entry!\nNote: These keywords are case sensitive.");
					break;
			}

			Console.ReadLine();

		}
	}

}
