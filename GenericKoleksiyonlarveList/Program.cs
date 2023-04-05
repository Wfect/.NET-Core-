using System;

namespace GenericKoleksiyonlarveList
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<T> class
            // List <string> renkler = new List<string>();
            //renkler.Add=("Renk1");
            //System.Collections.Generic namespaceinden geliyor.
            // T object türündedir ve nesne alabilir. Listenin içindeki nesnelerin tipini belirtiyor.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(10);
            sayiListesi.Add(11);
            sayiListesi.Add(15);
            sayiListesi.Add(16);
            sayiListesi.Add(17);
            sayiListesi.Add(1);
            sayiListesi.Add(8);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Renk1");
            renkListesi.Add("Renk2");
            renkListesi.Add("Renk3");
            renkListesi.Add("Renk4");
            renkListesi.Add("Renk5");

            //Kaç eleman var (count)
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            // Foreach ve List.ForEach ile Elemanlar
            //Elemanları
            foreach(var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach(var renk in renkListesi)
                Console.WriteLine(renk);

            // Elemanları bu şekilde yaparak da gösterebiliriz
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma(2 farklı metot )
            sayiListesi.Remove(1);
            renkListesi.Remove("renk1");
            //İndeks ile çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içinde arama
            if(sayiListesi.Contains(10)){
                Console.WriteLine(" 10 Liste içinde bulundu");
            }
            //Eleman ile indeksi bulma
            Console.WriteLine(renkListesi.BinarySearch("renk3"));

            //Diziyi Listeye çevirme
            string[] hayvanlar = {"Hayvan1","Hayvan2","Hayvan3"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanListesi.Clear();

            //Liste içinde nesne tutmak(class)
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "İsim1";
            kullanıcı1.Soyisim = "Soyisim1";
            kullanıcı1.Yas = 1;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "İsim2";
            kullanıcı2.Soyisim = "Soyisim2";
            kullanıcı2.Yas = 2;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı adı : " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı soyad : " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yas : " + kullanıcı.Yas);
            }


        }
    }

    public class Kullanıcılar{
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}

