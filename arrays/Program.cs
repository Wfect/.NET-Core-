using System;

namespace arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
        //Dizi tanımlama
        string[] renkler = new string[5]; // boyutu 5 olsun

        string[] hayvanlar = {"Kedi","Köpek",};

        int[] dizi;
        dizi = new int[5];

        //Dizilere değer atama ve erişim
        renkler[0]="Mavi";
        dizi[3]=10;
        
        Console.WriteLine(hayvanlar[0]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngüler ile dizi kullanımı
        //Klavyeden girilen n tane değerin ortalamasını alan program
        Console.WriteLine("Dizinin eleman sayısını giriniz");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("{0}. sayiyi giriniz", i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        
        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        {
            toplam +=sayi;
        }
        Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);

        }
    }
}
