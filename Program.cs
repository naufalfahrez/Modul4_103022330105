// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodeProduk {
    public enum Produk {
        Laptop,
        Smartphone,
        Tablet,
        Headset,
        Keyboard,
        Mouse,
        Printer,
        Monitor,
        Smartwatch,
        Kamera
    }

    private static string[] kodproduk = { "E100", "E101" , "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"};

    public static string getKodeProduk(Produk elektronik) {
        return kodproduk[(int) elektronik];
    }

    public static void Main()
    {
        Console.WriteLine("kode produk Laptop: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Laptop));
        Console.WriteLine("kode produk Smartphone: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Smartphone));
        Console.WriteLine("kode produk Tablet: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Tablet));
        Console.WriteLine("kode produk Headset: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Headset));
        Console.WriteLine("kode produk Keyboard: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Keyboard));
        Console.WriteLine("kode produk Mouse: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Mouse));
        Console.WriteLine("kode produk Printer: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Printer));
        Console.WriteLine("kode produk Monitor: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Monitor));
        Console.WriteLine("kode produk Smartwatch: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Smartwatch));
        Console.WriteLine("kode produk Kamera: " + KodeProduk.getKodeProduk(KodeProduk.Produk.Kamera));
    }
}


