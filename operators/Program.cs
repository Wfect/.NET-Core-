using System;

namespace operators
{
    class Program
    {
        public static void Main(string[] args)
        {
                int x = 2;
                int y = 3;
                y= y + 2;
                Console.WriteLine(y);
                y+=2;
                Console.WriteLine(y);
                y /=1;
                Console.WriteLine(y);
                x *= 2 ;
                Console.WriteLine(x);

                //Logical Operators
                // ||, && , !
                bool isSuccess = true;
                bool isCompleted = false;

                if(isSuccess && isCompleted) // isSuccess is isCompleted // is both true?
                {
                    Console.WriteLine("Perfect");
                }
                if(isSuccess || isCompleted)
                {
                    Console.WriteLine("Great");
                }
                if(isSuccess && !isCompleted)
                {
                    Console.WriteLine("Fine");
                }

                //Relational Operators
                // <, > <=,>=, ==, !=
                int a = 3;
                int b = 4;
                bool sonuc = a < b; // Sonuç a<b ise true olsun.
                Console.WriteLine(sonuc);
                sonuc = a>b;
                Console.WriteLine(sonuc);
                sonuc = a>=b;
                Console.WriteLine(sonuc);
                sonuc = a<=b;
                Console.WriteLine(sonuc);
                // Aritmetic Operators
                // +,-,/,*
                int sayi1 = 10;
                int sayi2 = 2;
                int sonuc1= sayi1/sayi2;
                Console.WriteLine(sonuc1);
                sonuc1 = sayi1 * sayi2;
                Console.WriteLine(sonuc1);
                sonuc1 = sayi1 + sayi2; 
                Console.WriteLine(sonuc1);
                sonuc1 = sayi1++;  
                Console.WriteLine(sonuc1);
                // % : mod 
                int sonuc2 = 20 % 3 ;
                Console.WriteLine(sonuc2);
          
            
        }
    }
}

