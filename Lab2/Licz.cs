using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Licz
    {
        private double value;

        public void Dodaj(double liczba)
        {
            this.value = value + liczba;
        }

        public void Odejmij(double liczba)
        {
            this.value = value - liczba;
        }

        public void ShowNumber()
        {
            Console.WriteLine($"Wartość liczby wynosi {value}");
        }

        public Licz(double value)
        {
            this.value = value;
        }

        public static Licz operator +(Licz a, Licz b)
        {
            return new Licz(a.value + b.value);
        }

    }
}

