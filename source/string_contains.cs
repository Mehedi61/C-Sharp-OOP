// Programmed by MD. Mehedi Hasan

using System;

namespace StringContains {

    class Contains {

        static void Main() {

            string str = "I am a C# developer !";

            if (str.Contains("C#")) {

                Console.WriteLine("The sequence 'C#' was found.");
            }
            
            else {
                
                Console.WriteLine("The sequence 'C#' was not found.");
            }

            Console.ReadLine();
        }
    }
}