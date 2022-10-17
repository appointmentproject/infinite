using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class structure
    {


        struct Books
      {
            private string Title;
            private string Author;
            private string Subject;
            private int Book_Id;

            public void GetValues()
            {
                Console.WriteLine("------Book Details-----");
                Console.WriteLine("Title  : " + Title);
                Console.WriteLine("Author : " + Author);
                Console.WriteLine("Subject: " + Subject);
                Console.WriteLine("Book ID: " + Book_Id);

            }
            public void ShowValues(string title, string authour, string subject, int book_id)
            {
                Title = title;
                Author = authour;
                Subject = subject;
                Book_Id = book_id;
            }
        
            public static void Main(string[] args)
            {
                Books books = new Books();
                books.ShowValues(".Net", "Anders Hejlsberg", "C#", 56570);
                books.GetValues();
                Console.Read();
            }

        }
      }
}
