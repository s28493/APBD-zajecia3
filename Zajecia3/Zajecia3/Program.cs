// See https://aka.ms/new-console-template for more information

using Zajecia3;
using Zajecia3.RodzajeKontenerow;

Kontenerowiec kontenerowiec1 = new Kontenerowiec(25, 50,500000);
KontenerChlodniczy kontenerChlodniczy = new KontenerChlodniczy("Fish",0);
KontenerNaGaz kontenerNaGaz = new KontenerNaGaz();
KontenerNaPlynyZwykle kontenerNaPlynyZwykle = new KontenerNaPlynyZwykle();
KontenerNaPlynyNiebiezpieczne kontenerNaPlynyNiebiezpieczne = new KontenerNaPlynyNiebiezpieczne();

kontenerChlodniczy.ZaladujLadunek(1000);

kontenerNaPlynyNiebiezpieczne.ZaladujLadunek(4999);
kontenerNaPlynyNiebiezpieczne.OproznijLadunek();

kontenerNaGaz.ZaladujLadunek(400);
kontenerNaGaz.OproznijLadunek();