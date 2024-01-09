using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	public abstract class Shape
	{
		float X;
		float Y;
		float Height;
		float Width;

		public virtual void Draw()
		{
			Console.WriteLine("Rysujemy kształt");
		}
	}
}
