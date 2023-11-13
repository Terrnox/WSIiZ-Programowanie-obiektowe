using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Reader : Person
    {
        private Book[] BookList;


        public void ViewBook()
        {
            Console.WriteLine("Lista przeczytanych książek:");
            for(int i=0;i<BookList.Length;i++)
            {
                Console.WriteLine($"{i+1}.{BookList[i].Title}");
            }
        }

        public new void View()
        {
            base.View();
            ViewBook();
        }
        public Reader(string FirstName, string LastName, int wiek, Book[] bookList): base(FirstName,LastName,wiek)
        {
            this._LastName = LastName;
            this._FirstName = FirstName;
            this.Wiek = wiek;
            this.BookList = bookList;
        }
    }
}
