using System;

namespace ifelse
{
    class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time<=11)
            Console.WriteLine("İyi sabahlar");
            else if(time<=18)
            Console.WriteLine("İyi günler");
            else
            Console.WriteLine("İyi akşamlar");
            // time <= 18 ise iyi günler değilse iyi akşamlar
            string sonuc = time<=18 ? "İyi günler" : "İyi akşamlar";
            Console.WriteLine(sonuc);
        }
    }
}

