namespace MyExampleMember;

public class SiparisAdimi : Adim
{
    public SiparisAdimi(IAlisveris alisveris) : base(alisveris)
    {
    }

    public override void Surdur()
    {
        _alisveris.Surec(this);
    }
}