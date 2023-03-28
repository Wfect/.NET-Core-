using System;

namespace recursive
{
    class Program
    {
        public static void Main(string[] args)
        {
                // Recursive : Öz yinelemeli fonksiyon
                // üs alma işlemini hem for hem recursive ile yap
                int result=1;
                for(int i =1; i<5; i++){
                    result *= 3;
                    Console.WriteLine(result);

                    İslem instance = new();
                    Console.WriteLine(instance.Üs(3,4));
                }

                // Extension Method
                // Extension methodlar ve classlar static olmalı
                string ifade = " deneme ";
                
                Console.WriteLine(ifade.ChechBosluk());

        }
    }

    public class İslem {

        public int Üs(int sayi, int üs ){
            if(üs < 2)
                return sayi;
            return Üs(sayi,üs-1) * sayi;     
        }
    }

    public static class Extension{
        public static bool ChechBosluk(this string param){
           return param.Contains(" ");
        }
    }
}

