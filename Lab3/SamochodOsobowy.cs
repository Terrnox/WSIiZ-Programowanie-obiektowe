using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class SamochodOsobowy:Samochod
    {
        double Waga;
        double PojemnoscSilnika;
        int IloscOsob;

        public new void View()
        {
            base.View();
            Console.WriteLine($"Waga:{Waga}\nPojemność silnika:{PojemnoscSilnika}\nIlość osób:{IloscOsob}");
        }

        public SamochodOsobowy()
        {
            do
            {
                Console.WriteLine("Podaj wagę z przedziału <2,4.5>");
                double waga = Convert.ToDouble(Console.ReadLine());
                Waga = waga;
            } while (Waga < 2 || Waga > 4.5);

            do {
                Console.WriteLine("Podaj pojemność silnika z przedziału <0.8,3.0>");
                double pojemnoscSilnika = Convert.ToDouble(Console.ReadLine());
                PojemnoscSilnika = pojemnoscSilnika;
            } while (PojemnoscSilnika < 0.8 || PojemnoscSilnika > 3.0 );
            do
            {
                Console.WriteLine("Podaj ilość osób (dodatnią)");
                int iloscOsob = Convert.ToInt32(Console.ReadLine());
                IloscOsob = iloscOsob;
            } while (IloscOsob <= 0);
        }

        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg,double waga,double pojemnosc,int ilosc):base(marka,model,nadwozie,kolor,rokProdukcji,przebieg)
        {
            this.marka = marka;
            this.model = model;
            this.nadwozie = nadwozie;
            this.kolor = kolor;
            this.rokProdukcji = rokProdukcji;
            if (waga > 4.5)
            {
                Waga = 4.5;
            }
            else if(waga < 2)
            {
                Waga = 2;
            }
            else
            {
                Waga = waga;
            }

            if(PojemnoscSilnika > 3.0)
            {
                PojemnoscSilnika = 3.0;
            }
            else if(PojemnoscSilnika < 0.8)
            {
                PojemnoscSilnika = 0.8;
            }
            else
            {
                PojemnoscSilnika = pojemnosc;
            }
            if(IloscOsob <= 0)
            {
                IloscOsob = IloscOsob*(-1);
            }
            else
            {
                IloscOsob = ilosc;
            }
        }
    }
}
