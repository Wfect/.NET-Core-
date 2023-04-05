using System;
using System.Collections;
using System.Collections.Generic

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Liste = new ArrayList(); 
            Liste.Add("İsim");   
            Liste.Add(2);
            Liste.Add(true);
            Liste.Add('a');

            // İçindeki verilere erişme
            Console.WriteLine(Liste[1]); 
            foreach (var item in Liste)
            {
                Console.WriteLine(item);
            }    
            // Addrange
            Console.WriteLine("Birden fazla eleman ekleme");
            string [] renkler = {"renk1","renk2","renk3"};
            List<int> sayilar = new List<int>(){1,3,8,6,7,11};
            Liste.Addrange(renkler);  
            Liste.Addrange(sayilar);     

            foreach (var item in Liste)
            {
                Console.WriteLine(item);
            }    

            //Sort
            Liste.Sort(); //RunTime'da hata verir.  

            //Binary Search : Önce sırala sonra binary search kullan.

            //Reverse
            Liste.Reverse();
        }
    }
}


