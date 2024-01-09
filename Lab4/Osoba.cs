using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	public abstract class Osoba
	{
		string Imie;
		string Nazwisko;
		string Pesel;

		public virtual void SetFirstName(string fistname)
		{
			Imie = fistname;
		}
		public virtual void SetLastName(string lastname)
		{
			Nazwisko = lastname;
		}
		public virtual void SetPesel(string pesel)
		{
			Pesel = pesel;
		}
		public virtual int GetAge()
		{
			int year = int.Parse(Pesel.Substring(0, 2));
			int age = DateTime.Now.Year - (1900 + year);

			return age;
		}

		public virtual void GetGender()
		{
			int numGender = int.Parse(Pesel.Substring(9, 1));
			if (numGender % 2 == 0) 
			{
				Console.WriteLine("Kobieta");
			}
			else
			{
				Console.WriteLine("Mężczyzna");
			}
		}

		public virtual void GetEducationInfo()
		{
			Console.WriteLine("Edukacja: Podstawowa");
		}

		public virtual void GetFullName()
		{
			Console.WriteLine($"Imie i nazwisko: {Imie} {Nazwisko}");
		}

		public virtual bool CanGoAloneToHome()
		{
			return true;
		}




	}
}
