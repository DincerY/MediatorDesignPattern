using MediatorMember;

Anakart anakart = new();

CDDriver cdDriver = new(anakart);
CPU cpu = new(anakart);
EkranKarti ekranKarti = new(anakart);
SesKarti sesKarti = new(anakart);


anakart.CDDriver = cdDriver;
anakart.CPU = cpu;
anakart.EkranKarti = ekranKarti;
anakart.SesKarti = sesKarti;

cdDriver.CDOku();




Console.WriteLine("Hello, World!");