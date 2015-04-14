using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Reader
    {
        
        private string pesel;
        private int age;
        private string name;


        public Reader()
        {
            name = "N/A";
        }

        public Reader(string name, int age,string pesel)
        {
            this.name = name;
            this.age = age;
            this.pesel = pesel;
        }

        public void PrintReaders()
        {
            Console.WriteLine("User {0}\t, age {1}\t Pesel {2}", name, age,pesel);
        }


    }

    



}
