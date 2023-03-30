using System;

namespace stringmetotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "String Metotlar";
            string degisken2 = "string ";

            // Length; Kaç harften oluşuyor
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat : birleştirme yapar.
            Console.WriteLine(string.Concat(degisken,"Merhaba"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0, 1 veya -1 döndürür
            Console.WriteLine(String.Compare(degisken,degisken2,true)); // True : büyük küçük harf duyarsız
            Console.WriteLine(String.Compare(degisken,degisken2,false)); // False : büyük küçük harf duyarlı

            //Contains
            Console.WriteLine(degisken.Contains(degisken2)); // degiskenin içinde degisken 2 var mı. Bulursa True dönüyor
            Console.WriteLine(degisken.EndsWith("metotlar"));
            Console.WriteLine(degisken.StartsWith("metotlar"));

            //index of 
            Console.WriteLine(degisken.IndexOf("String")); // İlk harfin indeksini verir.

            //İnsert
            Console.WriteLine(degisken.Insert(0,"merhaba"));
            //Lastindexof
            Console.WriteLine(degisken.LastIndexOf("t")); 

            //Padleft, Padright
            Console.WriteLine(degisken + degisken2.PadLeft(30)); // degisken 2 nin soluna 30a tamamlayacak kadar boşluk ekliyor
            Console.WriteLine(degisken + degisken2.PadLeft('*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            
            //Remove
            Console.WriteLine(degisken.Remove(10)); //10. indeksten sonrasını siliyor.
            Console.WriteLine(degisken.Remove(5,3)); //5.den başla 3tane sil
            Console.WriteLine(degisken.Remove(0,1)); //0. indeksten başla 1 tane sil

            //Replace
            Console.WriteLine(degisken.Replace("String","string"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));



        }
    }
}
