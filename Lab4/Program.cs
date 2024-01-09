using Lab4;

Console.WriteLine("Zadanie 1");

List<Shape> listaKsztaltow = new List<Shape>();
listaKsztaltow.Add(new Rectangle());
listaKsztaltow.Add(new Triangle());
listaKsztaltow.Add(new Circle());

foreach (Shape ksztalt in listaKsztaltow)
{
    ksztalt.Draw();
}

Console.WriteLine();
Console.WriteLine("Zadanie 2");
