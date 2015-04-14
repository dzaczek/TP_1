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
        private string idBook;
        private int isbn  ;
        private string name;
        private string date;
        

        public void PrintRents()   {      Console.Out.Writeline("Book {0}, Rent by {1}, Date {2}",idBook,name,date );    }

        public Rents(string idBook,int isbn,string name)
        {
          this.idBook=idBook;
    this.isbn=isbn;
    this.name=name;
    DateTime nowdate=DateTime.Now;
    this.date=nowdate.ToString();//"g",CultureInfo.CreareSpecifiCulture(""pl-PL")
        }


        

    }

}
