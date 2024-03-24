namespace Zajecia3.RodzajeKontenerow.Wyjatki;

public class OverfillException : Exception
{
    public OverfillException() 
    {
        Console.WriteLine("MASA ŁADUNKU JEST WIĘKSZA NIŻ POJEMNOŚĆ DANEGO KONTENERA");
    }
}