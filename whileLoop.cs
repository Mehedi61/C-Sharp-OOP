// Programmed by MD. Mehedi Hasan

using System;

namespace WhileLoop {

    class Loop {

        static void Main() {

            int n = 1;  // declaring a local variable 

            while (n <= 20) {
                
                // executing a while loop for printing 1 - 20
                Console.WriteLine("Value of N is: {0}", n);
                n++;
            }
            Console.ReadLine();
        }
    }
}
