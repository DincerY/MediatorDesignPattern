namespace MyExampleMember;

public class Alisveris : IAlisveris
{
    public void Surec(Adim adim)
    {
        if (adim is SiparisAdimi)
        {
            Console.WriteLine("Bu adım sipariş adımıdır.");
        }
        else if (adim is OdemeAdimi)
        {
            Console.WriteLine("Bu adım ödeme adımıdır.");
        }
        else
        {
            Console.WriteLine("Bu adım kargo adımıdır.");
        }
    }
}