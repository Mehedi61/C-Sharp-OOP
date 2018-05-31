using System;

namespace SmallestNumber {

    class NumberManipulator {

        public int FindMin (int num_one, int num_two) {
            // this is a public method
            int small;

            if (num_one < num_two) 
                small = num_one;
            else
                small = num_two;
            return small;
        }
    }
    class Program {

        static void Main() {

            int num_one = 60;
            int num_two = 40;
            int small;

            NumberManipulator r = new NumberManipulator();

            small = r.FindMin(num_one, num_two);

            Console.WriteLine("The smallest number is: {0}", small);
            Console.ReadLine();
        }
    }
}