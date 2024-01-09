using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	public class Wyjatki : ApplicationException
	{
		public void wypisz(string napis)
		{
			try
			{
				Console.WriteLine(napis.Length);
			}
			catch(NullReferenceException ex)
			{
				Console.WriteLine(ex.StackTrace);
				Console.WriteLine(ex.Message);
			}

		}


		//public Wyjatki(string text):base(text){ }

	}
}
