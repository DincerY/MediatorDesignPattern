using MyExampleMember;

IAlisveris alisveris = new Alisveris();
SiparisAdimi siparisAdimi = new SiparisAdimi(alisveris);
KargoAdimi kargoAdimi = new KargoAdimi(alisveris);
OdemeAdimi odemeAdimi = new OdemeAdimi(alisveris);

alisveris.Surec(siparisAdimi);
Thread.Sleep(1000);
alisveris.Surec(odemeAdimi);
Thread.Sleep(1000);
alisveris.Surec(kargoAdimi);
Thread.Sleep(1000);



Console.WriteLine("Süreç tamamlandı");