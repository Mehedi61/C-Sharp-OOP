// Programmed by MD. Mehedi Hasan

using System;

namespace StringCompare {

    class Compare {

        static void Main() {

            string name_one, name_two;

            name_one = "Mehedi";
            name_two = "Emon";

            if (string.Compare(name_one, name_two) == 0) {

                Console.WriteLine(name_one + " and " + name_two + " are same.");
            }

            else {

                Console.WriteLine(name_one + " and " + name_two + " are not same.");
            }

            Console.ReadLine();
        }
    }
}