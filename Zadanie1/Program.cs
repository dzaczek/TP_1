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
            List<Reader> reader = new List<Reader>();

            for (int i = 0; i < 100; i++)
            {
                reader.Add(new Reader(tools.RandomString(5, 22), randObj.Next(16, 85), "89890638555"));
                reader[i].PrintReaders();
            }
             Console.ReadKey();
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
