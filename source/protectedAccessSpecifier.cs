using System;

namespace ProtectedApplication {

    class Main_class {

        protected string first_name, last_name;  // these variables are protected

    }

    class Sub_Class: Main_class {
        // this is a sub class of Main class
        
        static void Main() {

            Sub_Class r = new Sub_Class();  

            r.first_name = "Mehedi ";  // accessing to protected member
            r.last_name = "Hasan";

            string full_name = r.first_name + r.last_name; // concatenating for making full name

            Console.WriteLine("Name: " + full_name);

            Console.ReadLine(); 
        }
    }
}