using System;

namespace örnek4
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Cümle giriniz : ");
            string cümle = Console.ReadLine();
            //Split : Cümledeki boşluk karakterlerinin dışında kelime sayısını hesaplar.
            int kelimeSayisi = cümle.Split(' ').Length; 
            //Replace : Boşluk karakterleri dışındaki harf sayısını hesaplar.
            // (" "): boşlukları gösterir.
            // ("") : boş karakteri gösterir.
            int harfSayisi = cümle.Replace(" ", "").Length;

            Console.WriteLine($"Girilen cümlede {kelimeSayisi} kelime ve {harfSayisi} harf vardır");
        }
    }
}



