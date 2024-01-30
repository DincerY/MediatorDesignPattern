namespace MyExampleMember;

public abstract class Adim
{
    protected IAlisveris _alisveris;

    protected Adim(IAlisveris alisveris)
    {
        _alisveris = alisveris;
    }

    public abstract void Surdur();
}