using Lab6;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

Plik plik1 = new Plik("program", "w67269");
plik1.Zapisz();
plik1.Wczytaj();

Plik plik2 = new Plik();
string path = @"pesel.txt";
plik2.WczytajISprawdzPESELE(path);

Plik plik3 = new Plik();
string path2 = @"db.json";

plik3.JSONReaderALL(path2);

plik3.JSONReaderSpecializedZakres(path2,"1970","2000","India","zakres");
plik3.JSONReaderSpecializedZakres(path2, "1965", "2010", "United States", "zakres");
plik3.JSONReaderSpecializedZakres(path2, "1980", "2018", "China", "zakres");
Console.WriteLine();

Console.WriteLine("Podaj kraj dla którego chcesz sprawdzić populacje (China/India/United States)");
string kraj = Console.ReadLine();
Console.WriteLine("Podaj rok dla którego chcesz sprawdzić populacje (1960-2019)");
string rok = Console.ReadLine();

if((kraj == "China" || kraj == "United States" || kraj == "India")  && (Convert.ToInt32(rok)>= 1960 && Convert.ToInt32(rok) <= 2019))
{
	plik3.JSONReaderSpecializedRok(path2, rok, kraj);
}
else
{
	Console.WriteLine("Podano błędny rok lub kraj");
}



Console.WriteLine("Podaj kraj dla którego chcesz sprawdzić wzrost populacji (China/India/United States)");
string krajC = Console.ReadLine();
Console.WriteLine("Podaj startowy rok dla którego chcesz sprawdzić wzrost populacji (1960-2019)");
string rokS = Console.ReadLine();
Console.WriteLine("Podaj końcowy rok dla którego chcesz sprawdzić wzrost populacji (1960-2019)");
string rokE = Console.ReadLine();
if ((krajC == "China" || krajC == "United States" || krajC == "India") && (Convert.ToInt32(rokS) >= 1960 && Convert.ToInt32(rokS) <= 2019) && (Convert.ToInt32(rokE) >= 1960 && Convert.ToInt32(rokE) <= 2019))
{
	plik3.JSONReaderSpecializedZakres(path2, rokS, rokE, krajC, "wzrost");
}
else
{
	Console.WriteLine("Podano błędny rok lub kraj");
}