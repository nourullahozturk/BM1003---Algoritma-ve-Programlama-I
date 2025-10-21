/*
12/10/2025

Soru 6:

Rastgele -100 ile 100 arasında 20 adet sayı oluşturun. Kaç tanesinin
pozitif, kaç tanesinin negatif olduğunu yazdırınız.
*/

namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet rastgele sayı üretiliyor...");
            int negatif_sayac = 0;
            int pozitif_sayac = 0;
            Random rastgele = new Random();
            int rastgele_sayi = rastgele.Next(-100, 100);           
            for (int i = 0; i < 20; i++)
            {
                if (rastgele_sayi < 0) negatif_sayac++;
                else if (rastgele_sayi > 0) pozitif_sayac++;
                rastgele_sayi = rastgele.Next(-100, 100);
            }
            Console.WriteLine(pozitif_sayac + " tane pozitif, " + negatif_sayac +
                " tane negatif sayı üretildi.");
        }
    }
}
/*
Ödev: rastgele üretilen sıfırların sayısını da ekrana yazın. 
*/