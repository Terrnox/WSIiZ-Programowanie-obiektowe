using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
	public class Adres
	{
		public string ulica { get; set; }
		public int numerDomu { get; set; }
		public string kodPocztowy { get; set; }

		public string miasto { get; set; }

		public Adres()
		{

		}
		public Adres(string ulica, int numerDomu, string kodPocztowy, string miasto)
		{
			this.ulica = ulica;
			this.numerDomu = numerDomu;
			this.kodPocztowy = kodPocztowy;
			this.miasto = miasto;
		}


	}
}
