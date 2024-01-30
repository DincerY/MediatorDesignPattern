namespace MyExampleMember;

public class OdemeAdimi : Adim
{
    public OdemeAdimi(IAlisveris alisveris) : base(alisveris)
    {
    }

    public void OdemeTamamla()
    {
        Console.WriteLine("Ödeme tamamlanıyor");
        _alisveris.Surec(this);
    }
}