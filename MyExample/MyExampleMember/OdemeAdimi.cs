namespace MyExampleMember;

public class OdemeAdimi : Adim
{
    public OdemeAdimi(IAlisveris alisveris) : base(alisveris)
    {
    }

    public override void Surdur()
    {
        _alisveris.Surec(this);
    }
}