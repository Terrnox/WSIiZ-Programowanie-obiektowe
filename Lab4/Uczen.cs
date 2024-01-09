using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	public class Uczen : Osoba
	{
		string Szkola;
		bool MozeSamWracacDoDomu;

		public void SetSchool(string szkola)
		{
			Szkola = szkola;
		}

		public void ChangeSchool(string szkola)
		{
			if (Szkola is not null) 
			{
				string poprzedniaSzkola = Szkola;
				Console.WriteLine($"Zmieno szkołę z {poprzedniaSzkola} na {szkola}");
			}
			else
			{
				Console.WriteLine($"Zapisano do szkoły: {szkola}");
			}
		}

		public void SetCanGoHomeAlone(bool wracac)
		{
			MozeSamWracacDoDomu = wracac;
		}

		public override void SetFirstName(string fistname)
		{
			base.SetFirstName(fistname);
		}

		public override void SetLastName(string lastname)
		{
			base.SetLastName(lastname);
		}

		public override void SetPesel(string pesel)
		{
			base.SetPesel(pesel);
		}

		public override int GetAge()
		{
			return base.GetAge();
		}

		public override void GetFullName()
		{
			base.GetFullName();
		}

		public override void GetGender()
		{
			base.GetGender();
		}

		public override void GetEducationInfo()
		{
			base.GetEducationInfo();
		}

		public override bool CanGoAloneToHome()
		{
			if(MozeSamWracacDoDomu == true || GetAge()>=12)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
