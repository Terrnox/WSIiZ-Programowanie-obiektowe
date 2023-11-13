using Lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Samochod
    {
        private string Marka;
        private string Model;
        private string Nadwozie;
        private string Kolor;
        private int RokProdukcji;
        private int Przebieg;

        public string marka
        {
            get { return Marka; }
            set { }
        }

        public string model
        {
            get { return Model; }
            set { }
        }

        public string nadwozie
        {
            get { return Nadwozie; }
            set { }
        }

        public string kolor
        {
            get { return Kolor; }
            set { }
        }

        public int rokProdukcji
        {
            get { return RokProdukcji; }
            set { }
        }

        public int przebieg
        {
            get { return Przebieg; }
            set { }
        }

        public void View()
        {
            Console.WriteLine($"Marka: {marka}\nModel: {model}\nNadwozie: {nadwozie}\nKolor: {kolor}\nRok produkcji: {rokProdukcji}\nPrzebieg: {przebieg}");
        }

        public Samochod()
        {
            Console.WriteLine("Podaj markę");
            string marka = Console.ReadLine();
            Marka = marka;
            Console.WriteLine("Podaj model");
            string model = Console.ReadLine();
            Model = model;
            Console.WriteLine("Podaj nadwozie");
            string nadwozie = Console.ReadLine();
            Nadwozie = nadwozie;
            Console.WriteLine("Podaj kolor");
            string kolor = Console.ReadLine();
            Kolor = kolor;
            Console.WriteLine("Podaj rok produkcji");
            int rokProdukcji = Convert.ToInt32(Console.ReadLine());
            RokProdukcji = rokProdukcji;
            do
            {
                Console.WriteLine("Podaj przebieg (nieujemny)");
                int przebieg = Convert.ToInt32(Console.ReadLine());
                Przebieg = przebieg;
            } while (przebieg < 0);
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            if (przebieg < 0)
            {
                Przebieg = 0;
            }
            else
            {
                Przebieg = przebieg;
            }
        }
    }
}
