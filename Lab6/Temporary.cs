using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	public class Temporary
	{
		public string starYear { get; set; }
		public string endYear { get; set; }

		public string country { get; set; }
		public int startYearPopulation { get; set; }
		public int endYearPopulation { get; set; }
		public Temporary() 
		{

		}

		public Temporary(string starYear, string endYear, string country,int startYearPopulation, int endYearPopulation)
		{
			this.startYearPopulation = startYearPopulation;
			this.endYearPopulation = endYearPopulation;
			this.starYear = starYear;
			this.endYear = endYear;
			this.country = country;
		}

		public void RoznicaPopulacji()
		{
			int roznica = endYearPopulation - startYearPopulation;
			Console.WriteLine($"Różnca populacji w {country} pomiędzy rokiem {starYear}, a {endYear} wynosi {roznica}.");
		}

		public void WzrostPopulacji()
		{
			double procent = ((Convert.ToDouble(endYearPopulation) - (Convert.ToDouble(startYearPopulation)))/ (Convert.ToDouble(startYearPopulation)))*100;
			Console.WriteLine($"Wzrost populacji w {country} pomiędzy rokiem {starYear}, a {endYear} wynosi {procent}%.");
		}
	}
}
