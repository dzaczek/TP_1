using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randObj=new Random();



            Tollsy tools = new Tollsy();
            List<Book> book = new List<Book>();

            book.Add(new Book(0,"Mr T","1234534562345","Jan Kochanowski"));
            for (int i = 0; i < 100; i++)
            {
                book.Add(new Book(i, tools.RandomString(15), tools.RandomString(4)+randObj.Next(10000000,12000000), tools.RandomString(14)));
                book[i].PrintBooks();
            }


          //  Console.Out.WriteLine(tools.RandomString(16));
            Console.ReadKey();
        }
    }
}
