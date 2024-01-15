using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Loader;
using System.ComponentModel.DataAnnotations;

namespace Lab7
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public int Age { get; set; }

		public Adres adres { get; set; }

		public string pesel { get; set; }

		public string email { get; set; }

	}
}
