using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Book
    {
    
        private string title;
        private string isbn;
        private string author;

        public Book() { }

        public Book(string title,string isbn,string author)
        {
            
            this.author = author;
            this.isbn = isbn;
            this.title = title;
            

        }

        public string Title { get { return title; } set { title = value; } }
        public string ISBN { get { return isbn; } set { isbn = value; } }
        public string Author { get { return author; } set { author = value; } }



        public void PrintBooks() { Console.Out.WriteLine(" Title: {0} \t Author: {1} \t,ISBN : {2}", title, author, isbn); }

        public String StringBook() { return "Title: " + title + " \t Author:"+ author +" \t,ISBN : "+isbn+"."; }
        public string returnTitle() { return title; }
        public string returnAuthor() { return author; }
        public string returnIsbn() { return isbn; }
        

    }
}
