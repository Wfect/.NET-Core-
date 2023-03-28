using System;

namespace motottanımlama
{
    class Program
    {
        public static void Main(string[] args)
        {
           //Out : 
           //Fonksiyona bir iş yaptırıp sonucunda değeri setlemek istiyorsan ve o değeri kullanmak istiyorsan kullanılır.
           string sayi = "111";
           int outSayi;
           bool sonuc = int.TryParse(sayi, out outSayi); // çeviriyorsan sayıyı out int outSayi şeklinde göster
           if(sonuc){
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
           }
           else{
                Console.WriteLine("Başarısız");
           }

           Metotlar instance = new Metotlar();
           instance.Topla(2,3, out int toplamSonuc);
           Console.WriteLine(toplamSonuc);

           // Metot Overloading (Aşırı Yükleme)
           int ifade = 111;
           instance.EkranaYazdir(Convert.ToString(ifade));
           instance.EkranaYazdir(ifade);
           // Metot imzası
           // Metot Adı + parametre sayisi + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b , out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri){ // overloading 
            Console.WriteLine(veri);
        }
    }
}
