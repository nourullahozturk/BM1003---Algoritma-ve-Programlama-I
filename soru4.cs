/*
11/10/2025

Soru 4:

Klavyeden girilen bir tam sayının pozitif negatif veya sıfır olduğunu
tespit eden programı yazınız. 
*/

namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
                Console.WriteLine("Sayı pozitiftir.");
            else if (sayi < 0)
                Console.WriteLine("Sayı negatiftir.");
            else
                Console.WriteLine("Sayı sıfırdır.");
        }
    }
}
