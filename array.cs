// Programmed by MD. Mehedi Hasan

using System;

namespace ArrayApp {

    class Array {

        static void Main() {

            int [] array = new int[11];  // declare an array of length 11
            int j;

            for (j = 0 ; j <= 10 ; j++) {
                
                array[j] = j + 100;
                Console.WriteLine("Index: [{0}] = Element: {1}", j, array[j]);  // print array's elements
           }

           Console.ReadLine();  // program end

        }
    }
}