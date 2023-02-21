using System;

namespace degiskenler
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str1=string.Empty;
            str1 = "String deneme";
            Console.WriteLine(str1);

            string ad = "Taner";
            string soyad = "Alaybeyoğlu";
            string TamIsım= ad + "" + soyad;
            Console.WriteLine(TamIsım);

            //ınteger type
            int integer1 = 3;
            int integer2 = 2;
            int integer3 = integer1+integer2;
            Console.WriteLine(integer3);

            //To.string keywords
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            //To.int keywords
            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //hour
            string hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(hour);



        }
    }
}

