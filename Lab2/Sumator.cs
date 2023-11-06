using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Sumator
    {
        private int[] Liczby;

        public int Suma()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                suma = suma + liczba;
            }

            return suma;
        }

        public int SumaPodziel2()
        {
            int suma = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                if (Liczby[i] % 2 == 0)
                {
                    suma += Liczby[i];
                }

            }
            return suma;
        }

        public int IleElementow()
        {
            return Liczby.Length;
        }

        public void PokazElementy()
        {
            Console.WriteLine("Elementy tablicy:");
            for (int i = 0; i < Liczby.Length; i++)
            {
                Console.Write(Liczby[i] + " ");
            }
        }

        public void Przedzial(int lowIndex, int highIndex)
        {
            if (lowIndex < 0)
            {
                lowIndex = 0;
            }
            if (highIndex >= Liczby.Length)
            {
                highIndex = Liczby.Length - 1; 
            }

            Console.WriteLine($"Elementy tablicy pomiędzy indeksami {lowIndex} i {highIndex}");
            for (int i = lowIndex;i<=highIndex;i++)
            {
                Console.Write(Liczby[i] + " ");
            }
        }

        public Sumator()
        {

        }

        public Sumator(int n)
        {
            Liczby = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                Liczby[i] = rnd.Next(100);
            }
        }

    }
}

