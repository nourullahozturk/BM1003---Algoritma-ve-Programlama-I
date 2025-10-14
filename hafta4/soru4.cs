/*
12/10/2025

Soru 6:

Bilgisayar 1–20 arasında rastgele bir sayı seçsin. Kullanıcı doğru
tahmin edene kadar sayılar girsin. Her tahminde ipucu verin:

Küçükse “Daha büyük!”
Büyükse “Daha küçük!”
Doğruysa “Tebrikler!”
*/

namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rastgele sayı seç
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 21);
            
            Console.WriteLine("1-20 arasında tuttuğum sayıyı tahmin et: ");
            
            int tahmin = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (tahmin > sayi)
                {
                    Console.WriteLine("Daha küçük");
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Daha büyük");
                }
                else
                {
                    Console.WriteLine("Tebrikler!");
                    break;
                }
                tahmin = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
/*
Ödev: belirli bir tahmin sayısı olsun. O sayıya ulaşıldığında hala
doğru tahmin yapılmamışsa "Kaybettiniz!" mesajı ile program sonlansın
*/