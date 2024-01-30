namespace MediatorMember;

public class SesKarti : Birim
{
    public SesKarti(IAnakart anakart) : base(anakart)
    {
    }
    public void SesVer(string sesData)
    {
        string[] datas = sesData.Split(",");
        foreach (string data in datas)
            Console.WriteLine($"Gelen ses : {data}");
    }
}