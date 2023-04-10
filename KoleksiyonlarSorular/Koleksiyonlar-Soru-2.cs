using System;
using System.Collections;

namespace koleksiyonlarsoru2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet sayının en büyük
            //3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi
            //içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama
            //toplamlarını console'a yazdıran programı yazınız.
            //(Array sınıfını kullanarak yazınız.)

            int[] numbers = new int[20];
            Console.WriteLine("20 tane sayi giriniz");
            int büyükToplam = 0;
            int kücükToplam = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine((i+1) + ". sayiyi giriniz");
                numbers [i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numbers);

            for (int i = 0; i < 3; i++)
            {
                kücükToplam = kücükToplam + numbers[i];
            }
            Console.WriteLine("Kücüklerin Toplami : " + kücükToplam);
            double kücüklerinOrtalamasi = kücükToplam / 3 ;
            Console.WriteLine("Kücüklerin Ortalamasi : " + kücüklerinOrtalamasi);

            for (int i = 19; i >= 17; i--)
            {
                büyükToplam = büyükToplam + numbers[i];
            }
            Console.WriteLine("Büyüklerin Toplami : " + büyükToplam);
            double büyüklerinOrtalamasi = büyükToplam / 3 ;
            Console.WriteLine("Büyüklerin Ortalamasi : " + büyüklerinOrtalamasi);

            double OrtalamaToplam = kücükToplam + büyükToplam;
            Console.WriteLine("Ortalamalarin Toplami : " + OrtalamaToplam);

            
            


            
        }
    }
}