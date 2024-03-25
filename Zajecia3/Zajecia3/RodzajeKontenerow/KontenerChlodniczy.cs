using Zajecia3.RodzajeKontenerow.Wyjatki;

namespace Zajecia3.RodzajeKontenerow;

public class KontenerChlodniczy : Kontener, IHazardNotifier
{
    protected String Produkt;
    protected float Temperatura;
    protected IDictionary<string, float> TemperaturyProduktow = new Dictionary<string, float>
    {
        {"Bananas", (float)13.3},
        {"Chocolate", 18},
        {"Fish", 2},
        {"Meat", -15},
        {"Ice cream", -18},
        {"Frozen pizza", -30},
        {"Cheese", (float)7.2},
        {"Sausages", 5},
        {"Butter", (float)20.5},
        {"Eggs", 19}
    };

    public KontenerChlodniczy(String produkt, float temperatura)
    {
        Temperatura = temperatura;
        SetNumerSeryjny();
        if (TemperaturyProduktow.ContainsKey(produkt))
        {
            Produkt = produkt;
            if (temperatura > TemperaturyProduktow[Produkt])
            {
                throw new ArgumentException("Zbyt wysoka temperatura kontenera do danego produktu");
            }
        }
        else
        {
            throw new ArgumentException("Nie mozna dac takiego produktu");
        }
    }

    public override void OproznijLadunek()
    {
        WagaLadunkuKG = 0;
        Console.WriteLine("Nowa masa ładunku to: " + WagaLadunkuKG);
    }

    public override void ZaladujLadunek(float ladunekDoZaladowania)
    {
        if (MaxLadownoscKontenera > ladunekDoZaladowania)
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
        NumerSeryjny = $"KON-C-{LicznikSeryjny}";
    }

    public void Powiadomienie()
    {
        Console.WriteLine("Niebezpieczna operacja za dużo towaru w kontenerze: " + NumerSeryjny);
    }
    
    public override string ToString()
    {
        return "Kontener chłodniczy: Produkt = " + Produkt + ", Temperatura = " + Temperatura + ", " + base.ToString();
    }
}