// Programmed by MD. Mehedi Hasan

using System;

namespace RectangleApplication {
    
    class Rectangle_Area {
        
        // member variables
        private double length;
        private double width;

        private void User_Input () {

            Console.Write("Enter the value of Length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Width: ");
            width = Convert.ToDouble(Console.ReadLine());

        }

        public void Copy_User_Input () {
            
            User_Input ();  // copied a private function to a public function of a same class to use it in another class. 
        }

        public double Calculate_Area () {
            
		return length * width;
        }

        public void Print_Result () {

            Console.WriteLine();
            Console.WriteLine("Area: {0}", Calculate_Area());
        }
    }       // end of class Rectangle_Area
    
    class Print_Rectangle {

        static void Main() {

            Rectangle_Area r = new Rectangle_Area();

            r.Copy_User_Input();
            r.Print_Result();

            Console.ReadLine();
        }
    }
}
