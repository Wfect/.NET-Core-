using System;

namespace örnek2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayiyi giriniz : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayiyi giriniz : ");
            int m = int.Parse(Console.ReadLine());

            int [] sayilar = new int [n];

            Console.WriteLine(" n tane sayi giriniz ");
            for ( int i = 0; i<n ; i++){
                Console.Write($"{i+1}. sayiyi giriniz ");
                sayilar [i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" m ' e tam bölünen yada eşit sayılar");
            for(int i = 0; i<n ; i++){
                if( sayilar[i] % m ==0 || sayilar[i] == m ){
                    Console.WriteLine(sayilar[i]);
                }
            }



        }
    }
}