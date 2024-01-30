namespace MediatorMember;

public class EkranKarti : Birim
{
    public EkranKarti(IAnakart anakart) : base(anakart)
    {
    }
    public void GorselVer(string videoData)
    {
        string[] datas = videoData.Split(",");
        foreach (string data in datas)
            Console.WriteLine($"Gelen görüntü : {data}");
    }
}