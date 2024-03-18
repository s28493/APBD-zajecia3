namespace Zajecia3;

public abstract class Kontener
{
    protected float WagaLadunkuKG { get; set; }
    protected float WysokoscCM { get; set; }
    protected float WagaWlasnaKG { get; set; }
    protected float GlebokoscCM { get; set; }
    protected float NumerSeryjny { get; set; }
    protected float MaxLadownoscKontenera { get; set; }
    protected Kontener(float wagaLadunkuKg, float wysokoscCm, float wagaWlasnaKg, float glebokoscCm, float numerSeryjny, float maxLadownoscKontenera)
    {
        WagaLadunkuKG = wagaLadunkuKg;
        WysokoscCM = wysokoscCm;
        WagaWlasnaKG = wagaWlasnaKg;
        GlebokoscCM = glebokoscCm;
        NumerSeryjny = numerSeryjny;
        MaxLadownoscKontenera = maxLadownoscKontenera;
    }
    public abstract void OproznijLadunek();
    public abstract void ZaladujLadunek(float ladunekDoZaladowania);
}