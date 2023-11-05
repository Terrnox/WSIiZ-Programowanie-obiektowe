using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            zadania();
        }


        static void showExercise()
        {
            Console.WriteLine("Wybierz zadania");
            Console.WriteLine("1. zadanie 1");
            Console.WriteLine("2. zadanie 2");
            Console.WriteLine("3. zadanie 3");
            Console.WriteLine("4. zadanie 4");
            Console.WriteLine("5. zadanie 5");
            Console.WriteLine("6. zadanie 6");
            Console.WriteLine("7. zadanie 7");
        }


        static void viewOptionsZadanie2()
        {
            Console.WriteLine("Wybierz operacje");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Różnica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potęga");
            Console.WriteLine("6. Pierwiastek kwadratowy");
            Console.WriteLine("7. Trygonometria");
            Console.WriteLine("8. Wyjście");
            Console.WriteLine("Twoj wybor");
        }

        static void viewOptionsZadanie3()
        {
            Console.WriteLine("Wybierz operacje");
            Console.WriteLine("1. Wyświetlanie tablicy od pierwszego elementu");
            Console.WriteLine("2. Wyświetlanie tablicy od ostatniego elementu");
            Console.WriteLine("3. Wyświetlanie elementów tablicy o nieparzystych elementach");
            Console.WriteLine("4. Wyświetlanie elementów tablicy o parzystych elementach");
            Console.WriteLine("5. Wyjście");
            Console.WriteLine("Twój wybór");
        }

        static void zadania()
        {
            while (true)
            {
                Console.Clear();
                showExercise();
                int operacja = Convert.ToInt32(Console.ReadLine());

                switch (operacja)
                {
                    case 1:
                        Console.Clear();
                        zadanie1();
                        break;
                    case 2:
                        Console.Clear();
                        zadanie2();
                        break;
                    case 3:
                        Console.Clear();
                        zadanie3();
                        break;
                    case 4:
                        Console.Clear();
                        zadanie4();
                        break;
                    case 5:
                        Console.Clear();
                        zadanie5();
                        break;
                    case 6:
                        Console.Clear();
                        zadanie6();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Podaj liczbę elementów w tablicy");
                        int n = inputInt();
                        zadanie7(n);
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Brak takiej opcji");
                        break;
                }
            }

        }


        static void zadanie1()
        {
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Podaj współczynniki równania kwadratowego a, b, c:");
            double a = inputDouble();
            double b = inputDouble();
            double c = inputDouble();

            if (a == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe");
            }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Równanie posiada 2 rozwiązania rzeczywiste: {x1} i {x2}");
                }
                else if (delta == 0)
                {
                    double x1 = (-b) / (2 * a);
                    Console.WriteLine($"Równanie posiada 1 podwójne rozwiązanie: {x1}");
                }
                else
                {
                    Console.WriteLine("Równanie nie posiada rozwiązań rzeczywistych");
                }
            }
            Environment.Exit(0);
        }

        static void zadanie2()
        {
            Console.WriteLine("Zadanie 2");
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                viewOptionsZadanie2();
                int operacja = Convert.ToInt32(Console.ReadLine());

                switch (operacja)
                {
                    case 1:
                        Console.Clear();
                        double a = inputDouble();
                        double b = inputDouble();
                        suma(a, b);
                        break;
                    case 2:
                        Console.Clear();
                        double c = inputDouble();
                        double d = inputDouble();
                        roznica(c, d);
                        break;
                    case 3:
                        Console.Clear();
                        double e = inputDouble();
                        double f = inputDouble();
                        iloczyn(e, f);
                        break;
                    case 4:
                        Console.Clear();
                        double g = inputDouble();
                        double h = inputDouble();
                        iloraz(g, h);
                        break;
                    case 5:
                        Console.Clear();
                        double i = inputDouble();
                        double j = inputDouble();
                        potega(i, j);
                        break;
                    case 6:
                        Console.Clear();
                        double k = inputDouble();
                        pierwiastekKwadratowy(k);
                        break;
                    case 7:
                        Console.Clear();
                        double l = inputDouble();
                        trygometria(l);
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Brak takiej opcji");
                        break;
                }
            }
        }

        static void zadanie3()
        {
            Console.WriteLine("Zadanie 3");
            double[] tab = wprowadzElementyDoTablicy(10);
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                viewOptionsZadanie3();
                int operacja = Convert.ToInt32(Console.ReadLine());

                switch (operacja)
                {
                    case 1:
                        Console.Clear();
                        wyswietlPrzod(tab);
                        break;
                    case 2:
                        Console.Clear();
                        wyswietlTyl(tab);
                        break;
                    case 3:
                        Console.Clear();
                        wyswietlElementyONieparzystychIndeksach(tab);
                        break;
                    case 4:
                        Console.Clear();
                        wyswietlElementyOParzystychIndeksach(tab);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Brak takiej opcji");
                        break;
                }

            }
        }

        static void zadanie4()
        {
            Console.WriteLine("Zadanie 4");
            double[] tab = wprowadzElementyDoTablicy(10);
            wyswietlSumeElementowTablicy(tab);
            wyswietlIloczynElementowTablicy(tab);
            wyswietlSredniaZElementowTablicy(tab);
            wyswietlMaxZElementowTablicy(tab);
            wyswietlMinZElementowTablicy(tab);
            Environment.Exit(0);
        }

        static void zadanie5()
        {
            Console.WriteLine("Zadanie 5");
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i ==19)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Environment.Exit(0);
        }

        static void zadanie6()
        {
            Console.WriteLine("Zadanie 6");
            int liczba = 0;
            do
            {
                liczba = inputInt();
                if (liczba < 0)
                {
                    Console.WriteLine("Przerwanie");
                    break;
                }
                Console.WriteLine(liczba);
            } while (true);
            Environment.Exit(0);
        }

        static void zadanie7(int n)
        {
            Console.WriteLine("Zadanie 7");
            double[] T = wprowadzElementyDoTablicy(n);
            Console.WriteLine("Nieposortowana tablica:");
            wyswietlPrzod(T);
            double pom = 0;
            int k = 0;
            int i = 1;
            while (i < n)
            {
                pom = T[i];
                k = i - 1;
                while (k >= 0 && T[k] > pom)
                {
                    T[k + 1] = T[k];
                    k = k - 1;
                }
                T[k + 1] = pom;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Posortowana tablica metodą wstawiania:");
            wyswietlPrzod(T);
            Environment.Exit(0);
        }

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

        static void suma(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine($"Suma {a} + {b} = {sum}");
        }

        static void roznica(double a, double b)
        {
            double roz = a - b;
            Console.WriteLine($"Różnica {a} - {b} = {roz}");
        }

        static void iloczyn(double a, double b)
        {
            double il = a * b;
            Console.WriteLine($"Iloczyn {a} * {b} = {il}");
        }

        static void iloraz(double a, double b)
        {
            if (b != 0)
            {
                double ilo = a / b;
                Console.WriteLine($"Iloczyn {a} * {b} = {ilo}");
            }
            else
            {
                Console.WriteLine("Dzielnik równy 0 - brak możliwości podzielenia");
            }
        }

        static void potega(double a, double b)
        {
            double pot = Math.Pow(a, b);
            Console.WriteLine($"Potęga liczb {a} i {b} = {pot}");
        }

        static void pierwiastekKwadratowy(double a)
        {
            if (a >= 0)
            {
                double pier = Math.Sqrt(a);
                Console.WriteLine($"Pierwiastek kwadratowy z liczby {a} = {pier}");
            }
            else
            {
                Console.WriteLine("Podano ujemną liczbę - nie da się obliczyć pierwiastka");
            }
        }

        static void trygometria(double a)
        {
            double rad = a * Math.PI / 180;
            Console.WriteLine("Sinus kąta " + a + " stopni" + " wynosi: " + Math.Sin(rad));
            Console.WriteLine("Cosinus kąta " + a + " stopni" + " wynosi: " + Math.Cos(rad));
            Console.WriteLine("Tangens kąta " + a + " stopni" + " wynosi: " + Math.Tan(rad));
        }

        static double[] wprowadzElementyDoTablicy(int n)
        {
            Console.WriteLine("Wprowadz 10 elementów do tablicy");
            double[] tab = new double[n];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine($"Podaj wartość dla {i}. elementu tablicy");
                tab[i] = inputDouble();
            }
            return tab;
        }

        static void wyswietlPrzod(double[] tab)
        {
            Console.WriteLine("Elementy tablicy od początku:");
            foreach (int item in tab)
            {
                Console.Write(item + " ");
            }
        }
        static void wyswietlTyl(double[] tab)
        {
            Console.WriteLine("Elementy tablicy od końca:");
            int koniec = tab.Length;
            for (int i = koniec - 1; i >= 0; i--)
            {
                Console.Write(tab[i] + " ");
            }
        }

        static void wyswietlElementyONieparzystychIndeksach(double[] tab)
        {
            Console.WriteLine("Elementy tablicy o nieparzystych indeksach");
            for (int i = 0; i < tab.Length; i = i + 2)
            {
                Console.Write(tab[i] + " ");
            }
        }


        static void wyswietlElementyOParzystychIndeksach(double[] tab)
        {
            Console.WriteLine("Elementy tablicy o parzystych indeksach");
            for (int i = 1; i < tab.Length; i = i + 2)
            {
                Console.Write(tab[i] + " ");
            }
        }

        static void wyswietlSumeElementowTablicy(double[] tab)
        {
            double suma = 0;
            for(int i = 0;i < tab.Length;i++)
            {
                suma += tab[i];
            }
            Console.WriteLine($"Suma elementów wynosi: {suma}");
        }

        static void wyswietlIloczynElementowTablicy(double[] tab)
        {
            double iloczyn = 1;
            for (int i = 0; i < tab.Length; i++)
            {
                iloczyn *= tab[i];
            }
            Console.WriteLine($"Iloczyn elementów wynosi: {iloczyn}");
        }

        static void wyswietlSredniaZElementowTablicy(double[] tab)
        {
            double suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            double srednia = suma / tab.Length;
            Console.WriteLine($"Średnia z elementów wynosi: {srednia}");
        }

        static void wyswietlMaxZElementowTablicy(double[] tab)
        {
            double max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
            Console.WriteLine($"Wartość maksymalna w tablicy wynosi: {max}");
        }

        static void wyswietlMinZElementowTablicy(double[] tab)
        {
            double min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            Console.WriteLine($"Wartość maksymalna w tablicy wynosi: {min}");
        }

    }
}



