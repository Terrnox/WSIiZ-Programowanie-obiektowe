using System;
using System.Text;

namespace Lab2
{
    class Program
    {
        static int inputInt()
        {
            Console.WriteLine("Podaj wartość");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        static double inputDouble()
        {
            Console.WriteLine("Podaj wartość");
            double a = Convert.ToDouble(Console.ReadLine());
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer zadania");
            int zadanie = inputInt();
            switch(zadanie)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Zadanie 0");
                    Osoba os1 = new Osoba("Zygfryd", "Labamba", 99, "Murzynowo");
                    os1.View();
                    Osoba os2 = new Osoba("Jan", "Kiwior", 29, "Krosno");
                    os2.View();

                    Console.WriteLine();

                    Osoba[] tab = new Osoba[5];

                    string[] tabImion = { "Ignacy", "Leslaw", "Wiktor", "Robert", "Ludwik", "Jan", "Lambert", "Tomasz", "Eryk", "Piotr" };
                    string[] tabNazw = { "Tomaszewski", "Kowal", "Kowalski", "Ungwalt", "Goral", "Rower", "Komin", "Lizak", "Szubryt", "Malinowski" };
                    string[] tabMiast = { "Rzeszow", "Murzynowo", "Krosno", "Chmielnik", "Gdynia", "Olsztyn" };

                    Random rnd = new Random();

                    for (int i = 0; i < tab.Length; i++)
                    {
                        tab[i] = new Osoba(tabImion[rnd.Next(10)], tabNazw[rnd.Next(10)], rnd.Next(100), tabMiast[rnd.Next(6)]);
                        tab[i].View();
                    }

                    Console.WriteLine();

                    foreach (Osoba item in tab)
                    {
                        item.View();
                    }
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Zadanie 1");
                    Licz l0 = new Licz(2.0);
                    Licz l1 = new Licz(300);
                    Licz l2 = new Licz(-5.0);
                    Console.WriteLine("Liczba l0");
                    l0.ShowNumber();
                    Console.WriteLine("Po dodaniu 2,5");
                    l0.Dodaj(2.5);
                    l0.ShowNumber();
                    Console.WriteLine("Liczba l1");
                    l1.ShowNumber();
                    l1.Odejmij(30);
                    Console.WriteLine("Po odjęciu 30");
                    l1.ShowNumber();
                    Console.WriteLine("Liczba l2");
                    l2.ShowNumber();
                    l2.Odejmij(30);
                    Console.WriteLine("Po odjęciu 30");
                    l2.ShowNumber();
                    Console.WriteLine("Po odjęciu -3");
                    l2.Odejmij(-5);
                    l2.ShowNumber();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Zadanie 2");
                    Sumator sum1 = new Sumator(10);
                    sum1.PokazElementy();
                    Console.WriteLine();
                    Console.WriteLine(sum1.SumaPodziel2());
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Zadanie 3");
                    Data d1 = new Data(32,-1,-1,44,78,88);
                    d1.PokazDate();
                    d1.PokazDziejszaDate();
                    Data d2 = new Data(23, 05, 23, 23, 59, 59);
                    d2.PokazDate();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Zadanie 4");
                    Console.WriteLine("Podaj liczbę");
                    string wartosc = Console.ReadLine();
                    Liczba liczba1 = new Liczba(wartosc);
                    Console.WriteLine("Podaj mnożnik");
                    int mnoznik = inputInt();
                    liczba1.Mnozenie(mnoznik);
                    Console.WriteLine($"Liczba {liczba1} pomnożona przez {mnoznik} wynosi:");
                    liczba1.PokazLiczbe();
                    Console.WriteLine();
                    int mnozenie = int.Parse(wartosc.ToString()) * mnoznik;
                    long silnia = liczba1.Silnia();
                    Console.WriteLine($"Silnia z liczby {mnozenie} wynosi: {silnia}");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wybrano złą opcję");
                    break;
            }

        }
    }


}
