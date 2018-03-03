// Programmed by MD. Mehedi Hasan

using System;

namespace StringCompare {

    class Compare {

        static void Main() {

            string name_one, name_two;

            Console.Write("Enter a name: ");
            name_one = Console.ReadLine();
            Console.Write("Enter another name: ");
            name_two = Console.ReadLine();

            if (string.Compare(name_one, name_two) == 0) {

                Console.WriteLine(name_one + " and " + name_two + " are equal.");
            }

            else {

                Console.WriteLine(name_one + " and " + name_two + " are not equal.");
            }

            Console.ReadLine();
        }
    }
}