using System;

namespace forloop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz");
            //Girilen sayıya kadar olan tek sayıları ekrana yazdır.
            int sayac = int.Parse(Console.ReadLine()); // Readline string değer okur. Bu nedenle int.parse ile dönüştürüyoruz. 
            for (int i = 0; i < sayac; i++)
            {
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
            }


            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içindeki toplamı
            int tekToplam = 0;
            int ciftToplam= 0;
            for (int i = 1; i <= 1000; i++)
            {
                if ( i % 2 == 1)
                    tekToplam += i; //tekToplam = tekToplam + i
                else
                    ciftToplam += i ;
            }
            Console.WriteLine("Tek Toplam " + tekToplam);
            Console.WriteLine("Çift Toplam " + ciftToplam);

            //Break ve continue
            
            for (int i = 0; i < 10; i++) 
            {
                if(i==4)
                    break; // i ==4 ise döngüyü sonlandırır.
                    Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    continue; // i == 4 ise 4ü atlar ve döngü devam eder
                    Console.WriteLine(i);
            }


        }
    }
}
