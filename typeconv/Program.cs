using System;

namespace operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Implicit Conv. (Bilinçsiz Dönüşüm), Düşük kapasiteli değişkenin kendinden büyük kapasiteli değişkene atanması
            byte a =5;
            sbyte b=30;
            short c=10;

            int d= a+b+c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i =h;
            Console.WriteLine("i:" + i);

            string e ="deneme";
            char f = 'k';
            object g =e+f+d;
            Console.WriteLine("g:"+ g);
            //Explicit Conv. (Bilinçli Dönüşüm)
            Console.WriteLine("Explict Conv");

            int x = 4 ;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            float w = 18.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v); 

            // ToString method
            Console.WriteLine("ToString Method");

            int xx=6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+ yy );

            // System.Convert
            Console.WriteLine("System.Convert");
            string s1 = "10", s2="20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1+sayi2;
            Console.WriteLine("Toplam : " + Toplam);

            //Parse, string ifadeleri dönüştürmek için kullanılır. Her zaman string alır
            Console.WriteLine("Parse Method");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin = "10.20";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            double1=Double.Parse(metin);

            Console.WriteLine("rakam 1:" + rakam1 );
            Console.WriteLine("double 1:" + double1 );
        }
    }
}


