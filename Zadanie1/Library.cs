using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Library
    {
        IDataStore booksStore = null;

        private List<Reader> reader = new List<Reader>();
       // private Dictionary<string, Book> book = new Dictionary<string, Book>();
        private ObservableCollection<Rents> rent = new ObservableCollection<Rents>();

        public Library(IDataStore ebooksStore)
        {
            this.booksStore = booksStore;

            // wypełnianie kolekcji: książki, czytelnicy
            this.booksStore.AddData("klucz1", new Book
                {
                    Title = "Taka sobie ksiazka",
                    ISBN = "1223",
                    Author = "Jan Kowalski"
                });

            this.booksStore.AddData("klucz2", new Book("Taka sobie ksiazka", "1223", "Jan Kowalski"));
        }

        public Book[] ListBooks()
        {
            // zwróci książki z kolekcji
            return null;
        }

        public Reader[] ListReaders()
        {
            // zwróci czytelników
            throw new NotImplementedException();
        }

        public void RentBook(string bookId, string readerId)
        {
            // wypozycz ksiazke bookId dla readerId - observable - wypozyczenie
            throw new NotImplementedException();
        }

        public Book[] ListRentedBooks()
        {
            // zwróci wypożyczone ksiązki
            throw new NotImplementedException();
        }
    }
}
