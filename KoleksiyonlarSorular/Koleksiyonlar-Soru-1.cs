using System;
using System.Collections;

namespace koleksiyonlarsoru1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [] sayilar = new int[5];
            for(int i = 0 ; i<sayilar.Length; i++){
                Console.Write((i+1) + ". sayiyi giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            double asalSayilarinToplami = 0;
            double asalOlmayanSayilarinToplami = 0;
            foreach (int item in sayilar)
            {
                bool asal = true;

                for(int j = 2; j<=item/2; j++){
                    if(item % j == 0){
                        asal=false;
                        break;
                    }
                }
                if(item == 1){
                    asal = false;
                }
                
                if(asal){
                    asalSayilar.Add(item);
                    asalSayilarinToplami = asalOlmayanSayilarinToplami + item;
                }
                else{
                    asalOlmayanSayilar.Add(item);
                    asalOlmayanSayilarinToplami = asalOlmayanSayilarinToplami + item;
                }
            }

            Console.WriteLine("Asal Sayilar");
            foreach (int item in asalSayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Asal olmayan Sayilar");
            foreach (int item in asalOlmayanSayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dizi elemanlarinin büyükten küçüğe siralamasi");
            Console.WriteLine("AsalSayilar elemanlarinin büyükten küçüğe siralamasi");

            asalSayilar.Sort();
            asalSayilar.Reverse();
            foreach (int item in asalSayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("AsalOlmayanSayilarin elemanlarinin büyükten küçüğe siralamasi");

            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();
        
            foreach (int item in asalOlmayanSayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Dizilerin eleman sayisi ve ortalaması");
            Console.WriteLine("Asal olan sayilarin sayisi ve ortalaması");
            Console.WriteLine("Asal sayilarin sayisi" + " " + asalSayilar.Count);
            Console.WriteLine("Asal sayilarin ortalamasi" + " " + asalSayilarinToplami / asalSayilar.Count);

            Console.WriteLine("Asal olmayan sayilarin sayisi" + " " + asalOlmayanSayilar.Count);
            Console.WriteLine("Asal olmayan sayilarin ortalamasi" + " " + asalOlmayanSayilarinToplami / asalOlmayanSayilar.Count);

            
        }
    }
}


