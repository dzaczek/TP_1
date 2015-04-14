using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Book
    {
        private int id;
        private string title;
        private string isbn;
        private string author;

        public Book(int id,string title,string isbn,string author)
        {
            this.id =   id;
            this.author = author;
            this.isbn = isbn;
            this.title = title;
            

        }

        public void PrintBooks() { Console.Out.WriteLine("Title: {0} \n Author: {1} \n,ISBN : {2}", title, author, isbn); }


    }
}
