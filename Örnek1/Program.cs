using System;

namespace örnek1
{
    class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Pozitif bir sayi girin: ");
        int n = int.Parse(Console.ReadLine());

        int[] sayilar = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i+1}. sayiyi girin: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Girilen çift sayilar:");
        for (int i = 0; i < n; i++)
        {
            if (sayilar[i] % 2 == 0)
            {
                Console.WriteLine(sayilar[i]);
            }
        }

        }
    }
}