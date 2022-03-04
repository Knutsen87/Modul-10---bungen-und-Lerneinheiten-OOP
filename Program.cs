
    Hund coco = new Hund();
    coco.Name = "Coco";
    coco.Alter = 10;
    coco.Rasse = "Collie";
    coco.Geschlecht = "Männlich";

    coco.Bellen();
    coco.Fressen();

    Console.ReadKey();


class Hund
{
    public string Name { get; set; }
    public byte Alter { get; set; }
    public string Rasse { get; set; }
    public string Geschlecht { get; set; }

    public void Bellen()
    {
        Console.WriteLine("{0} bellt!", Name);
    }
    public void Fressen()
    {
        Console.WriteLine("{0} frisst!", Name);
    }

}

