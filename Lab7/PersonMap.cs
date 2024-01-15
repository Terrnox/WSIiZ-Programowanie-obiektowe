using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
	public sealed class PersonMap : ClassMap<Person>
	{
		public PersonMap()
		{
			Map(m => m.FirstName).Name("FirstName");
			Map(m => m.LastName).Name("LastName");
			Map(m => m.adres.ulica).Name("ulica");
			Map(m => m.adres.numerDomu).Name("numerDomu");
			Map(m => m.adres.kodPocztowy).Name("kodPocztowy");
			Map(m => m.adres.miasto).Name("miasto");
			Map(m => m.pesel).Name("pesel");
			Map(m => m.email).Name("email");
		}
	}
}
