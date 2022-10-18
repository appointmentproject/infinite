using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Dotnet
{
    class Book
    {
        string bookname;
        string authorname;

        public Book(string bookname , string authorname)
        {
            this.bookname = bookname;
            this.authorname =authorname ;
        }

        public void Display()
        {
            Console.WriteLine(bookname + " " + "author is :" + authorname);
        }
    }
    class Bookshelf
    {
        Book[] bookobj = new Book[5];

        public Book this[int pos]
        {
            get { return bookobj[(int)pos]; }
            set { bookobj[(int)pos] = value; }
        }

        
        static void Main()
        {
            Bookshelf bs = new Bookshelf();
            bs[0] = new Book("C#", "anders hejlsberg");
            bs[1] = new Book("C++", "bjarne stroustrup");
            bs[2] = new Book("JAVA", "james gosling");
            bs[3] = new Book("HTML", "tim bernerslee");
            bs[4] = new Book("SQL", "donald");
            for (int i = 0; i < 5; i++)
            {
                bs[i].Display();
            }
            
            Console.Read();
        }
    }
}