using System;

namespace motottanımlama
{
    class Program
    {
        public static void Main(string[] args)
        {
           // Programları parçalamak için kullanılır.
           // Daha okunabilir kodlar yazmayı sağlıyor.
           // Metotlar class içinde yazılır.
           // Metot başka class içinde ise erişmek için instance oluşturmak gerekir.
           // erişim_belirteci geri dönüş tipi metot_adı(parametreListesi/argüman)
           // {
                    //code
                    //return
           // }

           // İki sayıyı topla
           int a = 2;
           int b = 3;
           Console.WriteLine(a+b);

           int sonuc = Topla(a,b);
           Console.WriteLine(sonuc);

           //İnstance 
           Metotlar ornek = new Metotlar();
           ornek.EkranaYazdir(Convert.ToString(sonuc));
           int sonuc2 = ornek.ArttırTopla(a,b);
           ornek.EkranaYazdir(Convert.ToString(sonuc2));
        }

        static int Topla(int deger1, int deger2){
            return (deger1 + deger2);
        }
    }
    class Metotlar{
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public int ArttırTopla(int deger1, int deger2){
            deger1+=1;
            deger2+=1;
            return deger1 + deger2 ;
        }
    }
}