using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Liczba
    {
        private int[] cyfry;

        public Liczba(string strLiczba)
        {
            int dl = strLiczba.Length;
            cyfry = new int[dl];

            byte[] ASCIIWartosci = Encoding.ASCII.GetBytes(strLiczba);
            
            for (int i = 0; i < dl; i++)
            {
                if (ASCIIWartosci[i] >= 48 && ASCIIWartosci[i] <= 57)
                {
                    cyfry[i] = int.Parse(strLiczba[i].ToString());
                }
                else
                {
                    Console.WriteLine("Podano znak, który nie jest cyfrą - błędna inicjalizacja");
                    break;
                }
            }
        }

        public void Mnozenie(int liczba)
        {
            int przeniesienie = 0;
            for (int i = cyfry.Length - 1; i >= 0; i--)
            {
                int cyfra = cyfry[i];
                int iloczyn = cyfra * liczba + przeniesienie;
                cyfry[i] = iloczyn % 10;
                przeniesienie = iloczyn / 10;
            }
            while (przeniesienie > 0)
            {
                int nowaCyfra = przeniesienie % 10;
                przeniesienie = przeniesienie / 10;

                int[] noweCyfry = new int[cyfry.Length + 1];
                noweCyfry[0] = nowaCyfra;

                for (int i = 0; i < cyfry.Length; i++)
                {
                    noweCyfry[i + 1] = cyfry[i];
                }

                cyfry = noweCyfry;
            }
        }

        public override string ToString()
        {
            return string.Join("", cyfry);
        }

        public void PokazLiczbe()
        {
            foreach (int cyfra in cyfry) 
            {
                Console.Write(cyfra);
            }
        }

        public long Silnia()
        {
            int n = int.Parse(this.ToString());
            long wynik = 1;

            for (int i = 2; i <= n; i++)
            {
                long a = (long)i;
                wynik = wynik * a;
            }

            return wynik;
        }
    }
}
