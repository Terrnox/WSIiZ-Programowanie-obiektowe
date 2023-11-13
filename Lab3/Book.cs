using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Book
    {
        private string title;
        private Person author;
        private DateOnly dataWydania;

        public string Title
        {
            get { return title; }
            set { }
        }

        public Person Author
        {
            get { return author; }
            set { }
        }
        public void View()
        {
            Console.WriteLine($"Tytuł:{title}\nAutor:{author._FirstName} {author._LastName}\nData wydania:{dataWydania}");
        }

        public Book(string title, Person author, DateOnly dataWydania)
        {
            this.title = title;
            this.author = author;
            this.dataWydania = dataWydania;
        }
    }
}
