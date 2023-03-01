using ConsoleApp2;

IPremia[] tab = { new Pracownik("Kowalski", "Jan", 1000) as IPremia,
                              new Dyrektor("Nowak", "Adam", 2000) as IPremia,
                              new Klient("Testowy", "Tomasz") as IPremia,
                        new DyrektorNaczelny("Nowak", "Jan", 1000, 3000) as IPremia};


foreach (IPremia i1 in tab)
{
    if (i1 != null)
    {
        Console.WriteLine($"{i1.GetType().Name} {i1.Premia()}");
    }
}



List<Pracownik> list = new List<Pracownik>();

list.Add(new Pracownik("Zielinska", "Zofia", 100));
list.Add(new Pracownik("Adamski", "Adam", 100));
list.Add(new Pracownik("Borowski", "Bartek", 100));
list.Add(new Pracownik("Czasny", "Czesław", 100));


list.Sort();

foreach (var item in list)
{
    Console.WriteLine($"{item.nazwisko} {item.imie}");
}

Console.ReadKey();
