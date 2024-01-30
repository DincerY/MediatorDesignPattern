using MyExampleMember;

Alisveris alisveris = new Alisveris();

SiparisAdimi siparisAdimi = new SiparisAdimi(alisveris);
KargoAdimi kargoAdimi = new KargoAdimi(alisveris);
OdemeAdimi odemeAdimi = new OdemeAdimi(alisveris);

alisveris._SiparisAdimi = siparisAdimi;
alisveris._OdemeAdimi = odemeAdimi;
alisveris._KargoAdimi = kargoAdimi;

alisveris.Surec(siparisAdimi);
Thread.Sleep(1000);




Console.WriteLine("Süreç tamamlandı");