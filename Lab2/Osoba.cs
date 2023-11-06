using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Osoba
    {
        private string firstName;
        private string lastName;
        private int age;
        private string city;

        public void View()
        {
            Console.WriteLine($"Imie:\t {firstName}\nNazwisko:\t{lastName}\nWiek:\t{age}\nMiasto:\t{city}");
        }

        public Osoba()
        {

        }
        public Osoba(string _firstName, string lastName, int age, string city)
        {
            firstName = _firstName;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
        }
    }
}

