namespace Zajecia3;

public abstract class Kontener
{
    protected float WagaLadunkuKG { get; set; }
    protected float WysokoscCM { get; set; }
    protected float WagaWlasnaKG { get; set; }
    protected float GlebokoscCM { get; set; }
    
    protected static int LicznikSeryjny = 0;
    protected String NumerSeryjny { get; set; }
    protected float MaxLadownoscKontenera { get; set; }
    protected Kontener()
    {
        LicznikSeryjny++;
        WagaLadunkuKG = 0;
        WysokoscCM = 1500;
        WagaWlasnaKG = 300;
        GlebokoscCM = 5000;
        MaxLadownoscKontenera = 10000;
    }
    public abstract void OproznijLadunek();
    public abstract void ZaladujLadunek(float ladunekDoZaladowania);
    public abstract void SetNumerSeryjny();
}