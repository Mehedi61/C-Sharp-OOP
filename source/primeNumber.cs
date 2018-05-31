// Programmed by MD. Mehedi Hasan

using System;

namespace PrimeNumberAPP {

    class Prime_Check {

        static void Main() {

            Console.Write("Enter a number to check whether it is prime or not: ");

            long prime_number = Convert.ToInt64(Console.ReadLine());

            if (prime_number > 1) {

                // Check whether the number is prime or not

                if (prime_number == 2 || prime_number % 2 != 0) {
                    
                    Console.WriteLine("{0} is a prime number.", prime_number);  // if the number is prime
                }

                else {
                    
                    Console.WriteLine("{0} is not a prime number.", prime_number);  // if the number is not prime
                }
            }

            else {

                Console.WriteLine("{0} is not a prime number.", prime_number);  // if prime == 1 
            }

            Console.ReadLine();

        }
    }

}