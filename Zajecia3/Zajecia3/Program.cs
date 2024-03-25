// See https://aka.ms/new-console-template for more information

using Zajecia3;
using Zajecia3.RodzajeKontenerow;

Kontenerowiec kontenerowiec1 = new Kontenerowiec(25, 50,500000);
Kontenerowiec kontenerowiec2 = new Kontenerowiec(10, 3, 50000);
KontenerChlodniczy kontenerChlodniczy = new KontenerChlodniczy("Fish",0);
KontenerNaGaz kontenerNaGaz = new KontenerNaGaz();
KontenerNaPlynyZwykle kontenerNaPlynyZwykle = new KontenerNaPlynyZwykle();
KontenerNaPlynyNiebiezpieczne kontenerNaPlynyNiebiezpieczne = new KontenerNaPlynyNiebiezpieczne();

Console.WriteLine("ŁADOWNIAE/ROZŁADOWWANIE ŁADUNKU");
Console.WriteLine("CHŁODNICZY: ");
kontenerChlodniczy.ZaladujLadunek(1000);

Console.WriteLine("\nPŁYNY NIEBEZPIECZNE: ");
kontenerNaPlynyNiebiezpieczne.ZaladujLadunek(4999);
kontenerNaPlynyNiebiezpieczne.OproznijLadunek();

Console.WriteLine("\nGAZ: ");
kontenerNaGaz.ZaladujLadunek(400);
kontenerNaGaz.OproznijLadunek();

Console.WriteLine("\nInformacje o pojedynczych kontenerach: ");
Console.WriteLine(kontenerNaPlynyZwykle);
Console.WriteLine(kontenerNaGaz);
Console.WriteLine(kontenerChlodniczy);

Console.WriteLine("\nZaładuj kontener na statek: ");
kontenerowiec2.ZaladujKontenerNaStatek(kontenerNaGaz);

Console.WriteLine("\nZastap kontener innym na statku: ");
kontenerowiec2.ZastapKontenerInnymNaStatku(0,kontenerChlodniczy);

Console.WriteLine("\nUsun kontener ze statku: ");
kontenerowiec2.UsunKontenerZeStatku(kontenerChlodniczy);

KontenerNaGaz k1 = new KontenerNaGaz();


//kontenerowiec2.ZaladujKontenerNaStatek(kontenerNaGaz);

Console.WriteLine("\nPrzenies kontener na inny statek:  ");
kontenerowiec2.PrzeniesKontenerNaInnyStatek(1, kontenerowiec1);

kontenerowiec1.InformacjeOStatku();
kontenerowiec2.InformacjeOStatku();

