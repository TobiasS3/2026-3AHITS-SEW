// ------------------------------
// Uebung_2_1
// ------------------------------

using System.Security.Cryptography.X509Certificates;

namespace Uebung_2_1;

class Schulklasse
{
    public int anzahlSchueler;
    public string namevorstand;

    public Schulklasse() : this(0, "Unbekannt") { }

    public Schulklasse(int anzahlSchuelerK, string namevorstandK)
    {
        anzahlSchueler = anzahlSchuelerK;
        namevorstand = namevorstandK;
    }
    public override string ToString()
    {
        return $"Anzahl der Schüler:{anzahlSchueler}, Name des Klassenvorstands: {namevorstand}";
    }

    public void Dazu()
    {
        anzahlSchueler += 1;
    }

    public void Raus(int entfernen)
    {
        anzahlSchueler -= entfernen;
    }
    public void KLassenwechselNACH(Schulklasse Wechsklasse)
    {
        anzahlSchueler += 1;
        Wechsklasse.anzahlSchueler -= 1;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Schulklasse AHITS = new Schulklasse(22, "Strasser");
        Schulklasse AHELS = new Schulklasse(20, "Falkner");
        Schulklasse AHEL = new Schulklasse();
        AHITS.Raus(3);
        AHELS.Dazu();
        AHITS.KLassenwechselNACH(AHELS);
        Console.WriteLine(AHITS);
        Console.WriteLine(AHELS);
        Console.WriteLine(AHEL);
    }


}