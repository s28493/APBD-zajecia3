using System.Security.AccessControl;
using Zajecia3.RodzajeKontenerow;
using Zajecia3.RodzajeKontenerow.Wyjatki;

namespace Zajecia3;

public class KontenerNaPlynyZwykle : Kontener, IHazardNotifier
{
    public KontenerNaPlynyZwykle()
    {
        WagaWlasnaKG = 350;
        SetNumerSeryjny();
    }
    
    public override void OproznijLadunek()
    {
        WagaLadunkuKG = 0;
        Console.WriteLine("Nowa masa ładunku to: " + WagaLadunkuKG);
    }

    public override void ZaladujLadunek(float ladunekDoZaladowania)
    {
        float maxWypelnienieKontenera = (float)(MaxLadownoscKontenera * 0.9);
        if (maxWypelnienieKontenera > ladunekDoZaladowania)
        {
            WagaLadunkuKG = ladunekDoZaladowania;
            Console.WriteLine("Nowa masa ładunku to: " + WagaLadunkuKG);
        }
        else
        {
            KontenerInfo();
            throw new OverfillException();
        }
    }

    public override void SetNumerSeryjny()
    {
        NumerSeryjny = $"KON-LZ-{LicznikSeryjny}";
    }

    public void KontenerInfo()
    {
        Console.WriteLine("Niebezpieczna operacja za dużo towaru w kontenerze: " + NumerSeryjny);
    }
}