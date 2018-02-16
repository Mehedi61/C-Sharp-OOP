// programmed by MD. Mehedi Hasan

using System;

namespace NestedSwitchApplication {
    
    class Academic_Identity {
        
        static void Main() {

            Console.WriteLine("Teacher / Student ?");
            
            string identity = Console.ReadLine();   // taking user input for identity

            switch (identity)
            {
                case "Teacher":
                case "teacher":

                    Console.WriteLine("You are a respected teacher.");
                    break;
                
                case "Student":
                case "student":

                    Console.Write("Your department: ");
                    string department = Console.ReadLine();   // taking user input for department
                    
                    switch (department) {
                        
                        // checking user's department

                        case "CMT":
                        case "cmt":
                        case "Computer":
                        case "computer":

                            Console.WriteLine("You are a student of Computer Technology .");   // if computer department
                            break;

                        case "Civil":
                        case "civil":
                        case "CIVIL":

                            Console.WriteLine("You are a student of Civil Technology . ");   // if civil department
                            break;

                        case "Electrical":
                        case "electrical":
                            
                            Console.WriteLine("You are a student of Electrical Technology .");   // if electrical department
                            break;
                    }
                break;
            }
        }
    }
}