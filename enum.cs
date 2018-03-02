// Programmed by MD. Mehedi Hasan

using System;

namespace EnumApp {

   class Enum {
      
      enum Numbers {zero, one, two, three, four, five};

      static void Main(string[] args) {
      
        int zero = (int)Numbers.zero;
        int one = (int)Numbers.one;
        int two = (int)Numbers.two;
        int three = (int)Numbers.three;
        int four = (int)Numbers.four;
        int five = (int)Numbers.five;

        Console.WriteLine("Zero: {0}", zero);
        Console.WriteLine("One: {0}", one);
	      Console.WriteLine("Two: {0}", two);
	      Console.WriteLine("Three: {0}", three);
	      Console.WriteLine("Four: {0}", four);
	      Console.WriteLine("Five: {0}", five);
        Console.ReadLine();
              
      }
   }
}
