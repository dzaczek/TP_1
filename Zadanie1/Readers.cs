using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Readers
    {
        private int pesel;
        private int age;
        private string name;


        public Readers()
        {
            name = "N/A";
        }

        public Readers(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public void PrintReaders()
        {
            Console.WriteLine("User {0}, age {1}", name, age);
        }


    }

    



}
