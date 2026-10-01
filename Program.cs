using SzallodaApp;

Szoba szoba = new Szoba(110, 20000);
Lakosztaly lakosztaly = new Lakosztaly(431, 150000, 30000);
szoba.Alapar = -200;
Console.WriteLine(szoba);
Console.WriteLine(lakosztaly);

Console.WriteLine($"3 éjszaka ára a 110-es szobában: {szoba.ArKiszamitas(3)} Ft");

Console.WriteLine($"3 éjszaka ára a 431-es lakosztályban: {lakosztaly.ArKiszamitas(3)} Ft");
