
class Hund
{
    public string Name { get; set; }
    public byte Alter { get; set; }
    public string Rasse { get; set; }
    public string Geschlecht { get; set; }

    static void Bellen(string Name)
    {
        Console.WriteLine( Name + "bellt!");
    }
    static void Fressen(string Name)
    {
        Console.WriteLine(Name + "frisst!");
    }

    public Hund(string name, byte alter, string rasse, string geschlecht)
    {
        Name = name;
        Alter = alter;
        Rasse = rasse;
        Geschlecht = geschlecht;
    }
}