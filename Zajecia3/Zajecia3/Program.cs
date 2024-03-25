// See https://aka.ms/new-console-template for more information

using Zajecia3;
using Zajecia3.RodzajeKontenerow;

Kontenerowiec kontenerowiec1 = new Kontenerowiec(25, 50,500000);
Kontenerowiec kontenerowiec2 = new Kontenerowiec(10, 3, 50000);
KontenerChlodniczy kontenerChlodniczy = new KontenerChlodniczy("Fish",0);
KontenerNaGaz kontenerNaGaz = new KontenerNaGaz();
KontenerNaPlynyZwykle kontenerNaPlynyZwykle = new KontenerNaPlynyZwykle();
KontenerNaPlynyNiebiezpieczne kontenerNaPlynyNiebiezpieczne = new KontenerNaPlynyNiebiezpieczne();

kontenerChlodniczy.ZaladujLadunek(1000);

kontenerNaPlynyNiebiezpieczne.ZaladujLadunek(4999);
kontenerNaPlynyNiebiezpieczne.OproznijLadunek();

kontenerNaGaz.ZaladujLadunek(400);
kontenerNaGaz.OproznijLadunek();

Console.WriteLine(kontenerNaPlynyZwykle);
Console.WriteLine(kontenerNaGaz);
Console.WriteLine(kontenerChlodniczy);

kontenerowiec2.ZaladujKontenerNaStatek(kontenerNaGaz);
kontenerowiec2.ZastapKontenerInnymNaStatku(0,kontenerChlodniczy);
kontenerowiec2.UsunKontenerZeStatku(kontenerNaGaz);

kontenerowiec2.ZaladujKontenerNaStatek(kontenerNaGaz);

Console.WriteLine("------------------");
kontenerowiec2.PrzeniesKontenerNaInnyStatek(1, kontenerowiec1);

kontenerowiec1.InformacjeOStatku();
kontenerowiec2.InformacjeOStatku();

