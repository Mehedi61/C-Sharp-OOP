// Programmed by MD. Mehedi Hasan

using System;

namespace Loop {
    
    class Do_While_Loop {
       
        static void Main() {

            int n = 1;

            do
            {
                Console.WriteLine("Value of N is: {0}", n);
                n = n + 1;

                // executing a do while loop for printing 1 - 20
            }
            while (n <= 20);
        }
    }
}