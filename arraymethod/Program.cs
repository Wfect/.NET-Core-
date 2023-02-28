class Program
{
    static void Main(string[] args)
    {
        //Sort
        int [] sayidizisi = {23,12,4,86,72,3,11,17};
        Console.WriteLine("Sırasız Liste");
        foreach (var sayi in sayidizisi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("Sıralı Liste");
        Array.Sort(sayidizisi);
        foreach (var sayi in sayidizisi)
        {
            Console.WriteLine(sayi);
        }

        //Clear
        Console.WriteLine("Array Clear");
        // sayiDizisi elemanlarını kullanarak 2. indeksten itibaren 2 tane elemanı 0 yapar
        Array.Clear(sayidizisi,2,2);
        foreach (var sayi in sayidizisi)
        {
            Console.WriteLine(sayi);
        }

        //Reverse
        Console.WriteLine("Reverse");
        Array.Reverse(sayidizisi);
        foreach (var sayi in sayidizisi)
        {
            Console.WriteLine(sayi);
        }

        //IndexOf
        Console.WriteLine("IndexOf");
        Console.WriteLine(Array.IndexOf(sayidizisi,23));

        //Resize
        Console.WriteLine("Resize");
        Array.Resize<int>(ref sayidizisi,9);
        sayidizisi[8] = 99;
        foreach (var sayi in sayidizisi)
        {
            Console.WriteLine(sayi);
        }

    }
}