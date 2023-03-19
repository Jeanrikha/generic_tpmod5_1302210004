using System;
using System.Collections;
using System.Collections.Generic;
using TP_mod5_1302210004;

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric HG = new HaloGeneric();
        HG.SapaUser("Jean");

        DataGeneric<string> DG = new DataGeneric<string>("1302210004");
        DG.PrintData();
    }
}