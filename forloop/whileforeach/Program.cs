using System;

namespace whileforeach
{
    class Program
    {
        public static void Main(string[] args)
        {
           //while
           //1den başlayarak girilen sayı dahil ortalamasını hesapla
           Console.WriteLine("Sayi giriniz");
           int sayi = int.Parse(Console.ReadLine());
           int sayac = 1;
           int toplam = 0;
           while (sayac<=sayi)
           {
                toplam = toplam + sayac;
                sayac++;
           }
           Console.WriteLine(toplam/sayi);

           // a'dan z'ye kadar tüm harfler
           char karakter = 'a';
           while (karakter<='z')
           {
            Console.Write(karakter);
            karakter++;
           }

           //foreach
           string [] arabalar = {"Araba1", "Araba2","Araba3"};
           foreach (var araba in arabalar)
           {
            Console.WriteLine(araba);
           }
        }
    }
}