using System;

namespace switchcase
{
    class Program
    {
        public static void Main(string[] args)
        {
            int month = DateTime.Now.Month; // Ayın integer karşılığını veriyor.

            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak ayındasınız");
                break;

                case 2:
                Console.WriteLine("Subat ayındasınız");
                break;

                default:
                Console.WriteLine("Yanlış veri girdiniz");
                break;
            }
            switch (month)// bu aylarda iseniz kış ayındasınız
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis ayındasınız");
                    break;
                default:
                break;
            }
        }
    }
}
