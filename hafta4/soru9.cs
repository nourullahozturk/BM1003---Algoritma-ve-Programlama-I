/*
12/10/2025

Soru 9:

Rastgele 0–100 arasında sayılar üretin.
Her sayıyı ekrana yazdırın.
Eğer sayı 90’dan büyükse döngüyü break ile sonlandırın.
Son olarak üretilen sayıların toplamını, ortalamasını ve üretilen
sayı adedini ekrana yazdırın.
*/

namespace soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rastgele sayı üret
            Random rastgele = new Random();
            int rastgele_sayi = rastgele.Next(0, 101);

            int sayac = 0;
            double toplam = 0;
            double ortalama = 0;

            Console.WriteLine("Rastgele sayılar üretiliyor...");
            while (true)
            {
                sayac++;
                toplam += rastgele_sayi;
                Console.WriteLine(rastgele_sayi);
                if (rastgele_sayi > 90) break;
                rastgele_sayi = rastgele.Next(0, 101);
            }
            Console.WriteLine("Üretilen sayıların toplamı: " + toplam +
                "\nÜretilen sayı adedi: " + sayac +
                "\nÜretilen sayıların ortalaması: " + toplam / sayac);
        }
    }
}