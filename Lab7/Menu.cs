using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace Lab7
{
	public class Menu
	{
		public string filePath;

		public Menu()
		{

		}
		public Menu(string filePath) 
		{
			this.filePath = filePath;
		}

		public void showMenu()
		{
			Console.WriteLine("Wybierz opcje");
			Console.WriteLine("1. Wyświetl dane");
			Console.WriteLine("2. Dodaj osobę");
			Console.WriteLine("3. Modyfikuj osobę");
			Console.WriteLine("4. Usuń osobę");
			Console.WriteLine("5. Wyjście z programu");
		}

		public void showData()
		{
			using (var reader = new StreamReader(filePath))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				csv.Context.RegisterClassMap<PersonMap>();
				var records = csv.GetRecords<Person>().ToList();

				Console.WriteLine("\nDane odczytane z pliku CSV:");
				foreach (var person in records)
				{
					Console.WriteLine($"Imię: {person.FirstName}\nNazwisko: {person.LastName}\nWiek: {person.Age}\nAdres: {person.adres.ulica} {person.adres.numerDomu}, {person.adres.kodPocztowy}, {person.adres.miasto}\nPESEL: {person.pesel}\nEmail: {person.email}");
				}
			}
		}


		public void addPerson(string imie, string nazwisko, int wiek, Adres adres, string pesel, string email)
		{
			Person osoba = new Person { FirstName = imie, LastName = nazwisko, Age = wiek, adres=adres, pesel=pesel, email = email };

			using (var writer = new StreamWriter(filePath,true))
			using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				csv.WriteRecord(osoba);
			}
			Console.WriteLine("Dane zapisane do pliku CSV.");
		}

		public void modifyPerson(string lookForPesel)
		{
			var records = new List<Person>();

			using (var reader = new StreamReader(filePath,true))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				csv.Context.RegisterClassMap<PersonMap>();
				records = csv.GetRecords<Person>().ToList();
			}

			var recordToUpdate = records.FirstOrDefault(p => p.pesel.Contains(lookForPesel));

			if (recordToUpdate != null)
			{
				Console.WriteLine("Enter updated information:");
				Console.WriteLine("Updated First Name:");
				recordToUpdate.FirstName = Console.ReadLine();

				using (var writer = new StreamWriter(filePath))
				using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
				{
					csv.Context.RegisterClassMap<PersonMap>();
					csv.WriteRecords(records);
				}

				Console.WriteLine("Osoba zaktualizowana w pliku CSV.");
			}
			else
			{
				Console.WriteLine("Nie znaleziono osoby o podanym PESEL do aktualizacji.");
			}
		}

		public void removePerson(string deleteForPesel)
		{
			var records = new List<Person>();

			using (var reader = new StreamReader(filePath,true))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				csv.Context.RegisterClassMap<PersonMap>();
				records = csv.GetRecords<Person>().ToList();
			}

			var recordToDelete = records.FirstOrDefault(p => p.pesel.Contains(deleteForPesel));

			if (recordToDelete != null)
			{
				records.Remove(recordToDelete);

				using (var writer = new StreamWriter(filePath))
				using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
				{
					csv.Context.RegisterClassMap<PersonMap>();
					csv.WriteRecords(records);
				}

				Console.WriteLine("Osoba usunięta z pliku CSV.");
			}
			else
			{
				Console.WriteLine("Nie znaleziono osoby o podanym PESEL do usunięcia.");
			}
		}


		public void Exit()
		{
			Environment.Exit(0);
		}

		public void showOptions()
		{
			Menu menu1 = new Menu("dane.csv");
			while (true)
			{
				Console.Clear();
				menu1.showMenu();
				int operacja = Convert.ToInt32(Console.ReadLine());

				switch (operacja)
				{
					case 1:
						Console.Clear();
						menu1.showData();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Podaj imie osoby:");
						string imie = Console.ReadLine();
						Console.WriteLine("Podaj nazwisko osoby:");
						string nazwisko = Console.ReadLine();
						Console.WriteLine("Podaj wiek osoby:");
						int wiek = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Podaj ulice:");
						string ulica = Console.ReadLine();
						Console.WriteLine("Podaj nr domu:");
						int nrDom = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Podaj kod pocztowy:");
						string kodPocztowy = Console.ReadLine();
						Console.WriteLine("Podaj miejscowość:");
						string miasto = Console.ReadLine();
						Adres adres = new Adres(ulica, nrDom, kodPocztowy, miasto);
						Console.WriteLine("Podaj PESEL osoby:");
						string pesel = Console.ReadLine();
						Console.WriteLine("Podaj adres e-mail osoby:");
						string email = Console.ReadLine();
						menu1.addPerson(imie,nazwisko,wiek,adres,pesel,email);
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Wyszukaj osobę poprzez PESEL");
						Console.WriteLine("Podaj szukany PESEL");
						string lookForPesel = Console.ReadLine();
						menu1.modifyPerson(lookForPesel);
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Wyszukaj osobę, którą chcesz usunąć poprzez PESEL");
						Console.WriteLine("Podaj szukany PESEL");
						string deleteForPesel = Console.ReadLine();
						menu1.removePerson(deleteForPesel);
						break;
					case 5:
						Console.Clear();
						menu1.Exit();
						break;
					default:
						Console.Clear();
						Console.WriteLine("Brak takiej opcji");
						break;
				}
			}

		}
	}
}
