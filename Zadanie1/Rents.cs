using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Zadanie1
{
    class Rents 
    {
        private string pesel;
        private string idBook;
        private string date;
        

      //public void PrintRents()   {      Console.Out.WriteLine("Book {0}, Rent by {1}, Date {2}",idBook,pesel,date );    }

        public Rents(string pesel, string idBook)
        {
            this.pesel = pesel;
            this.idBook=idBook;
            DateTime nowdate=DateTime.Now;
            this.date=nowdate.ToString();//"g",CultureInfo.CreareSpecifiCulture(""pl-PL")
        }

        public void printRecord()
    {
        Console.WriteLine("{0}\t{1}\t{2}",date,idBook,pesel);
    }
        

    }

}
