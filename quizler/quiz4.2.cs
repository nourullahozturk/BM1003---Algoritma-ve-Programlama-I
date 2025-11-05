/*
Quiz-4 – Şube 2

Bir sayının kendisi hariç pozitif tam bölenlerinin toplamı,
sayının kendisine eşitse bu sayıya mükemmel sayı denir.
Program, 10 000’e kadar olan tüm mükemmel sayıları ekrana yazdırsın.

Örnek Açıklama:
28 sayısı bir mükemmel sayıdır çünkü:
Pozitif bölenleri: 1, 2, 4, 7, 14
Toplamı: 1 + 2 + 4 + 7 + 14 = 28

Beklenen Çıktı (örnek):
Mükemmel sayılar:
6
28
496
8128
*/
namespace Quiz4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mükemmel sayılar:");
            int pozitif_bolen_toplam;
            for (int i = 1; i < 10000; i++) // sayı döngüsü
            {
                pozitif_bolen_toplam = 0;
                for (int j = 1; j < i; j++) // sayının pozitif bölenlerini toplayan döngü
                {
                    if (i % j == 0)
                    {
                        pozitif_bolen_toplam += j;
                    }
                }

                if (pozitif_bolen_toplam == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
