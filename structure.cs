
using System;

namespace BookInfoApp {

    struct Books {

        public string title;
        public string edition;
        public string author;
        public string subject;
        public string id;
    }

    public class Structure {

        public static void Main() {

            Books book_one;  // declare book_one of type Books
            Books book_two;  // declare book_two of type Books

            // book_one specification
            book_one.title = "Head First C#";
            book_one.edition = "3rd";
            book_one.author = "Andrew Stellman & Jennifer Greene";
            book_one.subject = "C# Programming Book";
            book_one.id = "68945";

            // book_two specifications
            book_two.title = "C# 6.0 in a Nutshell";
            book_two.edition = "6th";
            book_two.author = "Ben Albahari & Joseph Albahari";
            book_two.subject = "C# Programming Book";
            book_two.id = "54464";

            // print book_one info
            Console.WriteLine("Book title: {0}", book_one.title);
            Console.WriteLine("Edition: {0}", book_one.edition);
            Console.WriteLine("Author: {0}", book_one.author);
            Console.WriteLine("Subject: {0}", book_one.subject);
            Console.WriteLine("Book ID: {0}\n", book_one.id);

            // print book_two info
            Console.WriteLine("Book title: {0}", book_two.title);
            Console.WriteLine("Edition: {0}", book_two.edition);
            Console.WriteLine("Author: {0}", book_two.author);
            Console.WriteLine("Subject: {0}", book_two.subject);
            Console.WriteLine("Book ID: {0}", book_two.id);

            Console.ReadLine(); // program end 
        }
    }

}