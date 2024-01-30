namespace MyExampleMember;

public class KargoAdimi : Adim
{
    public KargoAdimi(IAlisveris alisveris) : base(alisveris)
    {
    }

    public void KargoTamamla()
    {
        Console.WriteLine("Kargo tamamlanıyor...");
        Console.WriteLine("Sipariş işlemleri sonlanmıştır. Keyifli alışverişler");
    }
}