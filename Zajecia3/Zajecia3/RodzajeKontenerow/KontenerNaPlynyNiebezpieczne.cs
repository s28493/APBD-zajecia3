namespace Zajecia3.RodzajeKontenerow;

public class KontenerNaPlynyNiebiezpieczne : Kontener, IHazardNotifier
{
    public KontenerNaPlynyNiebiezpieczne(float wagaLadunkuKg, float wysokoscCm, float wagaWlasnaKg, float glebokoscCm,
        float numerSeryjny, float maxLadownoscKontenera) : 
        base(wagaLadunkuKg, wysokoscCm, wagaWlasnaKg, glebokoscCm, numerSeryjny, maxLadownoscKontenera) {}

    public override void OproznijLadunek()
    {
        
    }

    public override void ZaladujLadunek(float LadunekDoZaladowania)
    {
        throw new NotImplementedException();
    }
}