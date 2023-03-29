using System;

namespace örnek3
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Pozitif tam sayi giriniz ");
            int n = int.Parse(Console.ReadLine());

            string [] kelimeler = new string[n];
            for(int i = 0 ; i<n; i++){
                Console.Write($"{i+1}. kelimeyi giriniz");
                kelimeler [i] = (Console.ReadLine());
            }
            
            Console.WriteLine("Kelimeler ");
            for(int i = n - 1; i>=0; i--){
                Console.WriteLine(kelimeler[i]);
            }

        }
    }
}
