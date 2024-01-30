namespace MyExampleMember;

public class SiparisAdimi : Adim
{
    public SiparisAdimi(IAlisveris alisveris) : base(alisveris)
    {
    }

    public void SiparisTamamla()
    {
        Console.WriteLine("Sipariş tamamlanıyor");
        _alisveris.Surec(this);
    }
}