

using ConsoleApp1;

List<IOsoba> osoby = new List<IOsoba>
{
    new Pracownik("Jan", "Nowak", "Katowice", "Miejska", 10),
    new Klient("Oskar", "Kowalski", "Ogrodowa", "Wrocław",  3),
    new Klient("Andrzej", "Zielinski", "Prosta", "Warszawa", 5 ),
    new Pracownik("Ola", "Wasilewski", "Piękna", "Opole", 7)
};

int sposobSortowania = 1;

Console.WriteLine("Podaj sposób sortowania (1 = Imie, 2 = Nazwisko, 3 = Miejscowosc, 4 = Ulica): ");
int.TryParse(Console.ReadLine(), out sposobSortowania);

List<IOsoba> result = new List<IOsoba>();

switch (sposobSortowania)
{
    case 1: result = osoby.OrderBy(x=>x.Imie).ToList(); break;
    case 2: result = osoby.OrderBy(x=>x.Nazwisko).ToList(); break;
    case 3: result = osoby.OrderBy(x=>x.Miejscowosc).ToList(); break;
    case 4: result = osoby.OrderBy(x=>x.Ulica).ToList(); break;
    default:
        result = osoby.OrderBy(x=> x.Imie).ToList(); break;
}

foreach (var osoba in result)
{
    Console.WriteLine(osoba.ToString());
}
