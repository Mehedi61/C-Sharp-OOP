// Programmed by MD. Mehedi Hasan

using System;

namespace StringJoining {

    class Join {

        static void Main() {
            
            string[] string_array = new string[] {"I am Mehedi.", "I am Hasan."};

            string new_string = string.Join("\n", string_array);

            Console.WriteLine(new_string);
            Console.ReadLine();
        }
    }
}