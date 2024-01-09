using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab6
{
	public class Plik
	{
		string nazwaPliku;
		string nrAlbumuAutoraPliku;

		public string NazwaPliku

		{
			get { return nazwaPliku; }
			set { }
		}

		public string NrAlbumuAutoraPliku

		{
			get { return nrAlbumuAutoraPliku; }
			set { }
		}

		public Plik()
		{

		}

		public Plik(string nazwaPliku, string nrAlbumuAutoraPliku)
		{
			this.nazwaPliku = nazwaPliku;
			this.nrAlbumuAutoraPliku = nrAlbumuAutoraPliku;
		}

		public void Zapisz()
		{
			File.WriteAllText(this.nazwaPliku + ".txt", this.nrAlbumuAutoraPliku);
		}

		public void Wczytaj()
		{
			if (File.Exists((this.nazwaPliku + ".txt")))
			{
				Console.WriteLine($"Zawartość pliku {this.nazwaPliku}.txt");
				string content = File.ReadAllText((this.nazwaPliku + ".txt"));
				Console.WriteLine(content);
			}
		}

		public void WczytajISprawdzPESELE(string path)
		{
			int dl = path.Length - 1;
			string nazwa = path.Substring(0, dl);
			StreamReader sr = File.OpenText(path);
			string outputText = "";
			int licznik = 1;
			int licznikZenski = 0;
			while ((outputText = sr.ReadLine()) != null)
			{
				if (outputText[9] % 2 == 0)
				{
					licznikZenski++;
				}
			}
			sr.Close();
			Console.WriteLine($"W pliku {nazwa} jest {licznikZenski} kobiet");
		}

		public void JSONReaderALL(string path)
		{
			string Serialized = File.ReadAllText(path);
			Console.WriteLine(Serialized);

			List<Populacja> dataList = JsonConvert.DeserializeObject<List<Populacja>>(Serialized);

			foreach (var data in dataList)
			{
				Console.WriteLine($"Indicator ID: {data.Indicator.Id}");
				Console.WriteLine($"Indicator Value: {data.Indicator.Value}");
				Console.WriteLine($"Country ID: {data.Country.Id}");
				Console.WriteLine($"Country Value: {data.Country.Value}");
				Console.WriteLine($"Value: {data.Value}");
				Console.WriteLine($"Decimal: {data.@Decimal}");
				Console.WriteLine($"Date: {data.Date}");
				Console.WriteLine();
			}
		}

		public void JSONReaderSpecializedZakres(string path, string starYear, string endYear, string country, string typ)
		{
			string Serialized = File.ReadAllText(path);

			List<Populacja> dataList = JsonConvert.DeserializeObject<List<Populacja>>(Serialized);

			Temporary temp = new Temporary("0", "0", country, 0, 0);

			if (typ == "zakres")
			{
				foreach (var data in dataList)
				{
					if (temp.starYear != "0" && temp.endYear != "0")
					{
						break;
					}
					else if (data.Country.Value == country)
					{
						if (data.Date == starYear)
						{
							temp.starYear = data.Date;
							temp.startYearPopulation = Convert.ToInt32(data.Value);
						}
						else if (data.Date == endYear)
						{
							temp.endYear = data.Date;
							temp.endYearPopulation = Convert.ToInt32(data.Value);
						}
					}

				}
				temp.RoznicaPopulacji();
			}
			else if (typ == "wzrost")
			{
				foreach (var data in dataList)
				{
					if (temp.starYear != "0" && temp.endYear != "0")
					{
						break;
					}
					else if (data.Country.Value == country)
					{
						if (data.Date == starYear)
						{
							temp.starYear = data.Date;
							temp.startYearPopulation = Convert.ToInt32(data.Value);
						}
						else if (data.Date == endYear)
						{
							temp.endYear = data.Date;
							temp.endYearPopulation = Convert.ToInt32(data.Value);
						}
					}

				}
				temp.WzrostPopulacji();
			}
		}

		public void JSONReaderSpecializedRok(string path, string year, string country)
		{
			string Serialized = File.ReadAllText(path);

			List<Populacja> dataList = JsonConvert.DeserializeObject<List<Populacja>>(Serialized);


			foreach (var data in dataList)
			{
				if (data.Date == year && data.Country.Value == country)
				{
					Console.WriteLine($"Dane dla kraju {country} w roku {year}\nPopulacja: {data.Value}");
					break;
				}
			}

		}
	}
}
