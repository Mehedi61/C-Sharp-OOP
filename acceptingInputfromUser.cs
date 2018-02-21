// programmed by MD. Mehedi Hasan

using System;

namespace Input_Accepting_Application {
    
    class accept_input {

        static void Main() {

        string user_name;   // declaring a variable

        Console.Write("Enter your name: ");

        user_name = Console.ReadLine();      // taking input from user

        Console.WriteLine("Your name is {0}.", user_name);

        Console.ReadLine();

        }
    }
}