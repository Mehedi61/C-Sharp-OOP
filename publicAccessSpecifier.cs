// Programmed by MD. Mehedi Hasan

using System;

namespace FullNameApplication {
    
    class Make_Name {
            
            // member variables
            public string first_name;
            public string last_name;

            public string Name() {
                // making full name
                return first_name + " " + last_name;
            }
            
            public void Display() {
                // display full name
                Console.WriteLine("Your full name is {0}.", Name());
            }
    }

    class Print_Name {
        
	    static void Main() {
            
	        Make_Name r = new Make_Name();  // creating instance of Make_Name() class.
            
            Console.Write("Enter your first name: ");
            r.first_name = Console.ReadLine();  // taking input for first_name
            
            Console.Write("Enter your last name: ");
            r.last_name = Console.ReadLine();  // taking input for last_name

            r.Display();  // printing full name
            
            Console.ReadLine();
        }
    }
}
