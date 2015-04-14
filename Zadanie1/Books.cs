using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Books
    {
        private int id;
        private string title;
        private  int isbn;
        private string author;

        public Books(int id,string title,int isbn,string author)
        {
            this.id =   id;
            this.author = author;
            this.isbn = isbn;
            this.title = title;
            

        }

        public void PrintBooks() { Console.Out.WriteLine("Title: {0} \n Author: {1} \n,ISBN : {2}", title, author, isbn); }


    }
}
