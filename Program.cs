﻿internal class Program
{
    private static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, hosgeldiniz!";
        string degisken2 = "CSharp";

        //Length
        Console.WriteLine(degisken.Length);

        //ToUpper , ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat
        Console.WriteLine(String.Concat(degisken,"Merhaba"));

        //Compare , CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
        Console.WriteLine(string.Compare(degisken,degisken2,true));
        Console.WriteLine(string.Compare(degisken,degisken2,false));

        //Contains
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
        Console.WriteLine(degisken.StartsWith("Merhaba"));

        //IndexOf
        Console.WriteLine(degisken.IndexOf("CS"));
        Console.WriteLine(degisken.IndexOf("ahmer"));

        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba! "));

        //LastIndexOf
        Console.WriteLine(degisken.LastIndexOf("i"));

        //PadLeft , PadRight
        Console.WriteLine(degisken + degisken2.PadLeft(30));
        Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
        Console.WriteLine(degisken.PadRight(50) + degisken2);
        Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

        //Remove
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(5,3));
        Console.WriteLine(degisken.Remove(0,1));

        //Replace
        Console.WriteLine(degisken.Replace("CSharp","C#"));
        Console.WriteLine(degisken.Replace(" ","*"));

        //Split
        Console.WriteLine(degisken.Split(' ')[1]);

        //Substring
        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4,6));
    }
}