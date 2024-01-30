namespace MediatorMember;

public abstract class Birim
{
    protected IAnakart _anakart;

    public Birim(IAnakart anakart)
    {
        _anakart = anakart;
    }
}