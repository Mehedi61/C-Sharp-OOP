// Programmed by MD. Mehedi Hasan

using System;

namespace NestedLoop {

    class Foor_Loop {

        static void Main() {

            int i, j;

            for (i = 2 ; i < 100 ; i++) {
                
                // finding prime numbers from 1 - 100 using nested for loop
                for (j = 2; j <= (i / j) ; j++) 
                
                if ((i % j) == 0) 
                break;  
                
                if (j > (i / j))
                
                Console.WriteLine("{0} is a prime number.", i);

            }
            Console.ReadLine();
        }
    }
}