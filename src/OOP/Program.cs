// ------------------------------
// OOP
// ------------------------------

using System.ComponentModel.DataAnnotations;

namespace OOP;

class Schule
{
    public string name; //member Varibale oder feld
    public int anzahlSchueler;
    public int anzahlLehrer;

    public int AnzahlPersonen()
    {
        return anzahlSchueler + anzahlLehrer;
    }

    //ToString() Methode
    public override string ToString()
    {
        return $"Schule: {name}, Schüler {anzahlSchueler}, Lehrer {anzahlLehrer}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Schule htl = new Schule(); //Obejekte erstellen (instanzieren)
        htl.name = "HTL Braunau";
        htl.anzahlSchueler = 800;
        htl.anzahlLehrer = 100;

        Console.WriteLine($"An der HTL {htl.name} gibt es {htl.AnzahlPersonen()} Schüler");

        //HLW
        Schule hlw = new Schule();
        hlw.name = "HLW Braunau";
        hlw.anzahlSchueler = 600;
        hlw.anzahlLehrer = 80;
        Console.WriteLine($"An der HTL {hlw.name} gibt es {hlw.AnzahlPersonen()} Schüler");


        //-----------------------------
        int n = 42;
        Console.WriteLine(n);
        Console.WriteLine(htl); //automatischer Aufruf von two String
        Console.WriteLine(htl.ToString);

    }
}
