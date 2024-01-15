using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

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
			try
			{
				if (IsCsvFileEmpty() == false)
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
				else
				{
					Console.WriteLine("Plik jest pusty");
				}
			}
			catch (FileNotFoundException)
			{
				Console.WriteLine($"Nie znaleziono pliku {filePath}");
			}
		}

		public bool IsCsvFileEmpty()
		{
			if (File.Exists(filePath))
			{
				long fileSize = new FileInfo(filePath).Length;

				return fileSize == 0;
			}
			else
			{
				return true;
			}
		}

		public void addPerson()
		{
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

            Person osoba = new Person(imie,nazwisko,wiek,adres,pesel,email);


            if (IsCsvFileEmpty())
			{
				using (var writer = new StreamWriter(filePath))
				using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
				{
					csv.WriteHeader<Person>();
					csv.NextRecord();
				}
			}

			using (var stream = new FileStream(filePath, FileMode.Append))
			using (var writer = new StreamWriter(stream))
			using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				csv.WriteRecord(osoba);
				writer.WriteLine();
			}

			Console.WriteLine("Dane dodane do pliku CSV.");
		}
		

		public void modifyPerson(string lookForPesel)
		{
			var records = new List<Person>();

			using (var reader = new StreamReader(filePath))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				csv.Context.RegisterClassMap<PersonMap>();
				records = csv.GetRecords<Person>().ToList();
			}

			var recordToUpdate = records.FirstOrDefault(p => p.pesel.Contains(lookForPesel));

			if (recordToUpdate != null)
			{
                Console.WriteLine("Podaj imie osoby:");
                recordToUpdate.FirstName = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko osoby:");
                recordToUpdate.LastName = Console.ReadLine();
                Console.WriteLine("Podaj wiek osoby:");
                recordToUpdate.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj ulice:");
                recordToUpdate.adres.ulica = Console.ReadLine();
                Console.WriteLine("Podaj nr domu:");
                recordToUpdate.adres.numerDomu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj kod pocztowy:");
                recordToUpdate.adres.kodPocztowy = Console.ReadLine();
                Console.WriteLine("Podaj miejscowość:");
                recordToUpdate.adres.miasto = Console.ReadLine();
                Console.WriteLine("Podaj PESEL osoby:");
                recordToUpdate.pesel = Console.ReadLine();
                Console.WriteLine("Podaj adres e-mail osoby:");
                recordToUpdate.email = Console.ReadLine();

				if (checkEmail(recordToUpdate.email) && checkPesel(recordToUpdate.pesel))
				{
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
					Console.WriteLine("Podano złe dane");
				}
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

        public bool checkEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		public bool checkPesel(string pesel)
		{
			bool check = true;
			int licznik = 0;

			for(int i = 0;i<pesel.Length;i++)
			{
				if (pesel[i] <= 48 && pesel[i] >= 57)
				{
					licznik++;
					check = false; break;
				}
			}

			if(pesel.Length == 11 && check == true)
			{
				return true;
			}
			else
			{
				return false;
			}

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
						Console.ReadKey();
						break;
					case 2:
						Console.Clear();
						menu1.addPerson();
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
