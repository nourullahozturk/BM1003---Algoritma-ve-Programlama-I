/*
Quiz-3 (Şube-1)

Kullanıcıdan 10 adet tam sayı girişi alarak bir diziye kaydediniz.
Program dizideki tek sayıların toplamını ve çift sayıların toplamını ayrı ayrı bulup ekrana yazdırsın.

Beklenen Çıktı (örnek):
    Sayı 1: 5
    Sayı 2: 8
    Sayı 3: 3
    Sayı 4: 12
    Sayı 5: 7
    Sayı 6: 4
    Sayı 7: 10
    Sayı 8: 9
    Sayı 9: 2
    Sayı 10: 11
    Tek sayıların toplamı: 45
    Çift sayıların toplamı: 36
*/
namespace Quiz3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cift_toplam = 0;
            int tek_toplam = 0;
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                // kullanıcıdan sayı al
                Console.Write($"Sayı {i+1}: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                // sayıyı diziye kaydet
                dizi[i] = sayi;
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    cift_toplam += dizi[i];
                }
                else
                {
                    tek_toplam += dizi[i];
                }
            }
            Console.WriteLine($"Tek sayıların toplamı: {tek_toplam}");
            Console.WriteLine($"Cift sayıların toplamı: {cift_toplam}");
        }
    }
}
