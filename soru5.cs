/*
12/10/2025

Soru 5:

Klavyeden girilen 3 sayıdan en büyüğünü bulan programı yazınız.
*/

namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üç sayı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            // sayi1, sayi2 ve sayi3'ten büyükse:
            if (sayi1 >= sayi2 && sayi1 >= sayi3)
                Console.WriteLine(sayi1 + "en büyüktür.");
            // önceki koşul sağlanmazsa sayi1, sayi2 ve sayi3'den küçük
            // geriye sayi2 ve sayi3 kaldı. sayi2 büyükse: 
            else if (sayi2 >= sayi3)
                Console.WriteLine(sayi2 + "en büyüktür.");
            // sayi3 büyükse:
            else
                Console.WriteLine(sayi3 + "en büyüktür.");
        }
    }
}
