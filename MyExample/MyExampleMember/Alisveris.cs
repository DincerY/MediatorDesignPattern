namespace MyExampleMember;

public class Alisveris : IAlisveris
{
    public KargoAdimi _KargoAdimi { get; set; }
    public OdemeAdimi _OdemeAdimi { get; set; }
    public SiparisAdimi _SiparisAdimi { get; set; }  
    
    public void Surec(Adim adim)
    {
        if (adim is SiparisAdimi)
        {
            Console.WriteLine("Bu adım sipariş adımıdır.");
            _OdemeAdimi.OdemeTamamla();
            
        }
        else if (adim is OdemeAdimi)
        {
            Console.WriteLine("Bu adım ödeme adımıdır.");
            _KargoAdimi.KargoTamamla();
        }

    }
}