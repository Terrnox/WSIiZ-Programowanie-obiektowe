using Lab3;

Person p1 = new Person("Jan","Nowak",21);
Person p2 = new Person("Bartłomiej","Kikolski",31);
Person p3 = new Person("Bartosz", "Kikolski", 32);

Console.WriteLine("Osoba 1");
p1.View();
Console.WriteLine("Osoba 2");
p2.View();
Console.WriteLine("Osoba 3");
p3.View();

Console.WriteLine();

var data1 = new DateOnly(1936, 4, 12);
Book b1 = new Book("Lokomotywa", p1 , data1);
var data2 = new DateOnly(1997, 4, 10);
Book b2 = new Book("Harry Potter", p2 , data2);
var data3 = new DateOnly(2022, 9, 10);
Book b3 = new Book("Łabędzi krzyk", p3, data3);

Console.WriteLine("Książka 1");
b1.View();
Console.WriteLine("Książka 2");
b2.View();
Console.WriteLine("Książka 3");
b3.View();

Console.WriteLine();

Book[] tabBook1 = { b1, b2, b3 };
Book[] tabBook2 = { b2, b3 };
Reader r1 = new Reader("Zygfryd", "Nowomiejski", 45,tabBook1);
Reader r2 = new Reader("Bogdan", "Starowiejski", 50, tabBook2);

Console.WriteLine("Metoda ViewBook\n");
r1.ViewBook();
r2.ViewBook();

Console.WriteLine();

Console.WriteLine("Metoda View\n");
r1.View();
r2.View();

Console.WriteLine();

Samochod s1 = new Samochod();
Samochod s2 = new Samochod("Seat","Ibiza","Combi","Czerwony",2019,23789);
Console.WriteLine("Samochód z inputa:");
s1.View();
Console.WriteLine("Samochód Seat:");
s2.View();

Console.WriteLine();

Samochod so1 = new SamochodOsobowy();
Samochod so2 = new SamochodOsobowy("Volvo", "V90", "Cross", "Szary", 2022, 1098,2.44,1.96,5);
Console.WriteLine("Samochód osobowy z inputa:");
so1.View();
Console.WriteLine("Samochód osobowy Volvo:");
so2.View();