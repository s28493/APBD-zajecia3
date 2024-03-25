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

    public void ZaladujKontenerNaStatek(Kontener kontener)
    {
        if (KonteneryNaStatku.Count < MaxLiczbaKontenerow)
        {
            if (kontener.getWagaKontenera() + ObecnaWagaKontenerow < MaxWagaKontenerow)
            {
                KonteneryNaStatku.Add(kontener);
                Console.WriteLine("Dodano: " + kontener);
                ObecnaWagaKontenerow += kontener.getWagaKontenera();
            }
            else
            {
                throw new InvalidOperationException("Zbyt duza waga");
            }
        }
        else
        {
            throw new InvalidOperationException("Zbyt duzo kontenerow na statku");
        }
    }

    public void ZaladujWszystkieKonteneryNaStatek(List<Kontener> kontenery)
    {
        foreach (Kontener kontener in kontenery)
        {
            ZaladujKontenerNaStatek(kontener);
        }
    }

    public void UsunKontenerZeStatku(Kontener kontener)
    {
        if (KonteneryNaStatku.Contains(kontener))
        {
            ObecnaWagaKontenerow -= kontener.getWagaKontenera();
            KonteneryNaStatku.Remove(kontener);
            Console.WriteLine("Usunieto " + kontener);
        }
        else
        {
            Console.WriteLine("Nie ma tkaiego kontenera na statku");
        }
    }

    public void ZastapKontenerInnymNaStatku(int numerKontenera, Kontener kontener)
    {
        if (numerKontenera >= 0 && numerKontenera <= KonteneryNaStatku.Count)
        {
            Kontener kontenerLokalny = KonteneryNaStatku[numerKontenera];
            KonteneryNaStatku.Remove(kontenerLokalny);
            ObecnaWagaKontenerow -= kontenerLokalny.getWagaKontenera();
            
            Console.WriteLine("Zastapiono "  + kontenerLokalny);
            ZaladujKontenerNaStatek(kontener);
        }
        else
        {
            Console.WriteLine("Nie ma kontenera o podanym numerze");
        }
    }
    
    
    // Możliwość przeniesienie kontenera między dwoma statkami
    // Wypisanie informacji o danym statku i jego ładunku
    
    
    


}