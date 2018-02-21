// Programmed by MD. Mehedi Hasan

using System;

namespace RectangleApplication {
    
    class Rectangle_Area {
        
        // member variables
        private double length;
        private double width;

        private void Accept_Details () {

            Console.Write("Enter the value of Length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of Width: ");
            width = Convert.ToDouble(Console.ReadLine());

        }

        public void Get_Accept_Details() {
            
            Accept_Details();
        }

        public double Get_Area () {
            return length * width;
        }

        public void Display () {

            Console.WriteLine();
            Console.WriteLine("Area: {0}", Get_Area());
        }
    } // end of class Rectangle
    
    class Print_Rectangle {

        static void Main() {

            Rectangle_Area r = new Rectangle_Area();
            r.Get_Accept_Details();
            r.Display();
            Console.ReadLine();
        }
    }
}