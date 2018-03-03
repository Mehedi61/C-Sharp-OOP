// Programmed by MD. Mehedi Hasan

using System;

namespace StringSubstring {

    class Substring {

        static void Main() {

            string str = "I am a C# developer !";
            Console.WriteLine("string: {0}", str);

            string sub_str = str.Substring(7,12);
            Console.WriteLine("substring: {0}", sub_str);
        }
    }
}