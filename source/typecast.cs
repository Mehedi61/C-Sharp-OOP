// Programmed by MD. Mehedi Hasan

using System;

namespace TypecastingApplication {
    
    class ExplicitTypeCast {
    
        static void Main() {
    
            double x = 36.34;
            int y = (int)x;     // Type casting
    
            Console.WriteLine("double: {0}\ninteger: {1}", x, y);
            Console.ReadLine();
        }
    }
}