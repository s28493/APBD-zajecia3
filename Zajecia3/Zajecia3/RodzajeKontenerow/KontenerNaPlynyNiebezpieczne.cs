using Zajecia3.RodzajeKontenerow.Wyjatki;

namespace Zajecia3.RodzajeKontenerow;

public class KontenerNaPlynyNiebiezpieczne : Kontener, IHazardNotifier
{
    public KontenerNaPlynyNiebiezpieczne()
    {
        WagaWlasnaKG = 450;
        SetNumerSeryjny();
    }
    public override void OproznijLadunek()
    {
        WagaLadunkuKG = 0;
        Console.WriteLine("Nowa masa ładunku to: " + WagaLadunkuKG);
    }

    public override void ZaladujLadunek(float ladunekDoZaladowania)
    {
        float maxWypelnienieKontenera = (float)(MaxLadownoscKontenera * 0.5);
        if (maxWypelnienieKontenera > ladunekDoZaladowania)
        {
            WagaLadunkuKG = ladunekDoZaladowania;
            Console.WriteLine("Nowa masa ładunku to: " + WagaLadunkuKG);
        }
        else
        {
            Powiadomienie();
            throw new OverfillException();
        }
    }

    public override void SetNumerSeryjny()
    {
        NumerSeryjny = $"KON-LN-{LicznikSeryjny}";
    }

    public void Powiadomienie()
    {
        Console.WriteLine("Niebezpieczna operacja za dużo towaru w kontenerze: " + NumerSeryjny);
    }
    
    public override string ToString()
    {
        return "Kontener na płyny niebezpieczne: " + base.ToString();
    }
}