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
        
            List<Reader> reader = new List<Reader>();

            for (int i = 0; i < 100; i++)
            {
                reader.Add(new Reader(tools.RandomString(5, 22), randObj.Next(16, 85), "89890638555"));
                reader[i].PrintReaders();
            }
             Console.ReadKey();


             Dictionary<string, Book> _book = new Dictionary<string, Book>();




              for (int i = 0; i < 100; i++)
            {

                _book.Add(tools.RandomStringHash(8),new Book(i, tools.RandomString(15), tools.RandomString(4)+randObj.Next(10000000,12000000), tools.RandomString(14)));
              //  book.Add(new Book(i, tools.RandomString(15), tools.RandomString(4)+randObj.Next(10000000,12000000), tools.RandomString(14)));
                //book[i].PrintBooks();
            }


              Console.ReadKey();
            foreach(KeyValuePair<string, Book> kvp in _book)
            {
                Console.WriteLine("{0},  {1}", kvp.Key, kvp.Value.PrintBooks());
            }

          //  Console.Out.WriteLine(tools.RandomString(16));
            Console.ReadKey();
        }
    }
}
