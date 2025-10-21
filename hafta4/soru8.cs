/*
12/10/2025

Soru 8:

1’den 100’e kadar olan sayıların:
Tek olanların toplamını
Çift olanların toplamını ayrı ayrı hesaplayınız.

Beklenen çıktı:
	Tek toplam = 2500  
	Çift toplam = 2550
*/

namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tek_toplam = 0;
            int cift_toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) cift_toplam += i;
                else tek_toplam += i;
            }
            Console.WriteLine("1'den 100'e kadar olan;\n" +
                "    tek sayıların toplamı: " + tek_toplam + "\n" +
                "    çift sayıların toplamı: " + cift_toplam);
        }
    }
}