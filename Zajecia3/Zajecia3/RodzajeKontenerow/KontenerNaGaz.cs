using Zajecia3.RodzajeKontenerow.Wyjatki;

namespace Zajecia3.RodzajeKontenerow;

public class KontenerNaGaz : Kontener, IHazardNotifier
{
    protected float cisnienie;
    public KontenerNaGaz()
    {
        cisnienie = 0;
        WagaWlasnaKG = 150;
        SetNumerSeryjny();
    }

    public override void OproznijLadunek()
    {
        WagaLadunkuKG = (float)(WagaLadunkuKG * 0.05);
        cisnienie = WagaLadunkuKG / MaxLadownoscKontenera * 10;
        Console.WriteLine("Nowa masa ładunku to: " + WagaLadunkuKG + " a cisnienie to: " + cisnienie);
    }

    public override void ZaladujLadunek(float ladunekDoZaladowania)
    {
        float maxWypelnienieKontenera = (float)(MaxLadownoscKontenera * 0.5);
        if (maxWypelnienieKontenera > ladunekDoZaladowania+WagaLadunkuKG)
        {
            WagaLadunkuKG += ladunekDoZaladowania;
            cisnienie = WagaLadunkuKG / MaxLadownoscKontenera * 10;
            Console.WriteLine("Nowa masa ładunku to: " + WagaLadunkuKG + " a cisnienie to: " + cisnienie);
        }
        else
        {
            Powiadomienie();
            throw new OverfillException();
        }
    }

    public override void SetNumerSeryjny()
    {
        NumerSeryjny = $"KON-G-{LicznikSeryjny}";
    }

    public void Powiadomienie()
    {
        Console.WriteLine("Niebezpieczna operacja za dużo towaru w kontenerze: " + NumerSeryjny);
    }
    public override string ToString()
    {
        return "Kontener na gaz: ciśnienie = " + cisnienie + ", " + base.ToString();
    }
}