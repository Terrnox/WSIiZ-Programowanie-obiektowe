using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	public class Nauczyciel : Uczen
	{
		string TytulNaukowy;
		List<Uczen> PodwladniUczniowie;
		void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
		{

			Console.WriteLine($"Data: {dateToCheck}\nLista uczniów mogących iść samemu do domu:");
			foreach (Uczen uczen in PodwladniUczniowie) 
			{
				if (uczen.CanGoAloneToHome() == true)
				{
					uczen.GetFullName();
				}
			}
		}
	}
}
