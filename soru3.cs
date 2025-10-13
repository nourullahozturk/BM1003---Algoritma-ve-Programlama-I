/*
12/10/2025

Soru 3:

Klavyeden girilen bir tam sayının tek mi veya çift mi olduğunu
tespit eden programı yazınız. 

*/

namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
                Console.WriteLine("Sayı çifttir");
            else
                Console.WriteLine("Sayı tektir");
        }
    }
}
