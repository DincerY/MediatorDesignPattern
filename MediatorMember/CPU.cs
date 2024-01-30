﻿namespace MediatorMember;

public class CPU : Birim
{
    public CPU(IAnakart anakart) : base(anakart)
    {
    }
    string _videoData, _sesData;
    public string VideoData => _videoData;
    public string SesData => _sesData;
    public void DataIsle(string cdData)
    {
        string[] array = cdData.Split("*");
        _videoData = array[0]; //görüntü değerleri video data olarak alınıyor.
        _sesData = array[1]; //ses değerleri ses data olarak alınıyor.
        _anakart.Degistir(this);
    }
}