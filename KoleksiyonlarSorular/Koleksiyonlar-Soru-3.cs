using System;
using System.Collections;

namespace koleksiyonlarsoru3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Klavyeden girilen cümle içerisindeki sesli harfleri
            //bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Cümle giriniz : ");
            string cümle = Console.ReadLine();
            char[] sesliler = {'A','E','I','İ','O','Ö','U','Ü','a','e','ı','i','o','ö','u','ü'};
            //Cümledeki sesli harfler için dizi oluşturulması
            char[] cümledekiSesliler = new char[cümle.Length];
            //cümledekiSesliler için eleman ekleme sırası
            int index = 0 ; 
            
            for (int i = 0; i < cümle.Length; i++)
            {
                if(Array.IndexOf(sesliler, cümle[i]) != -1){
                    cümledekiSesliler[index] = cümle[i];
                    index++;
                }
            }
            Array.Sort(cümledekiSesliler);
            Console.WriteLine("Cümledeki sesliler : ");
            foreach (var item in cümledekiSesliler)
            {
                Console.WriteLine(item);
            }
        }
    }
}