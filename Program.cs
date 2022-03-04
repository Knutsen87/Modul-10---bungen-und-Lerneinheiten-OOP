
Hund coco = new Hund("Coco", 10, "Collie", "Männlich");
Console.WriteLine(coco.Name);
Console.WriteLine(coco.Alter);
Console.WriteLine(coco.Rasse);
Console.WriteLine(coco.Geschlecht);
coco.Bellen();
coco.Fressen();

Console.ReadKey();


class Hund
{
    public string Name { get; set; }
    public byte Alter { get; set; }
    public string Rasse { get; set; }
    public string Geschlecht { get; set; }

    public Hund(string name, byte alter, string rasse, string geschlecht)
    {
        Name = name;
        Alter = alter;
        Rasse = rasse;
        Geschlecht = geschlecht;
    }

    public void Bellen()
    {
        Console.WriteLine("\n{0} bellt!", Name);
    }
    public void Fressen()
    {
        Console.WriteLine("{0} frisst!", Name);
    }

}

