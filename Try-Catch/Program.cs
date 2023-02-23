using System;

namespace TryCatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            try{ //Hata olabilen kod
            //Hatalar oluşma zamanına göre 2 ye ayrılır. Compile ve RunTime hataları
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayi" + sayi);

            }
            catch(Exception ex){ // Hata olursa ne yapacağın
            Console.WriteLine("Hata" + ex.Message.ToString());
            }
            //finally{
            //Console.Write("İşlem Tamamlandı");
            //}

            try{
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000000");
            }
            catch(ArgumentException ex ){  
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);

            }
            catch(OverflowException ex){
                Console.WriteLine("Değer çok büyük veya çok küçük");
                Console.WriteLine(ex);

            }
            
        }
    }
}
