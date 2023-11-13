using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private int wiek;

        public string _FirstName
        {
            get { return FirstName; }
            set { }
        }

        public string _LastName
        {
            get { return LastName; }
            set { }
        }

        public int Wiek
        {
            get { return wiek; }
            set { }
        }

        public void View()
        {
            Console.WriteLine($"Imie: {FirstName}\nNazwisko: {LastName}\nWiek: {wiek} lat.");
        }

        public Person(string FirstName, string LastName, int wiek)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.wiek = wiek;
        }
    }
}
