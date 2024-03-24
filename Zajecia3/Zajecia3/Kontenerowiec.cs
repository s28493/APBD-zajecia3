namespace Zajecia3;

public class Kontenerowiec
{
    public List<Kontener> KonteneryNaStatku = new List<Kontener>();
    public int MaxWezlow;
    public int MaxLiczbaKontenerow;
    public float MaxWagaKontenerow;
    public float ObecnaWagaKontenerow = 0;
    public int IDStatku = 0;

    public Kontenerowiec(int maxWezlow, int maxLiczbaKontenerow, float maxWagaKontenerow)
    {
        MaxWezlow = maxWezlow;
        MaxLiczbaKontenerow = maxLiczbaKontenerow;
        MaxWagaKontenerow = maxWagaKontenerow;
        IDStatku++;
    }
    
    
    // Załadowanie kontenera na statek
    // Załadowanie listy kontenerów na statek
    // Usunięcie kontenera ze statku
    // Zastąpienie kontenera na statku o danym numerze innym kontenerem
    // Możliwość przeniesienie kontenera między dwoma statkami
    // Wypisanie informacji o danym kontenerze
    // Wypisanie informacji o danym statku i jego ładunku
    
    
    


}