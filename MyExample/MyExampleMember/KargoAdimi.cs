﻿namespace MyExampleMember;

public class KargoAdimi : Adim
{
    public KargoAdimi(IAlisveris alisveris) : base(alisveris)
    {
    }

    public override void Surdur()
    {
        _alisveris.Surec(this);
    }
}