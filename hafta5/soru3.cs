/*
21/10/2025
Soru 3:

100 elemanlı bir dizi oluşturun ve diziyi 0 ile 20 arasında rastgele
sayılarla doldurun.Kullanıcıdan bir sayı alın ve bu sayının dizide
kaç kez geçtiğini bulan programı yazınız.

Çıktı:

Dizi: [4, 7, 0, 12, 7, 7, 15, 3, 7 , 2, ...]
Bir sayı giriniz: 7
7 sayısı dizide 4 kez geçiyor
*/

namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dizi tanımla
            int[] dizi = new int[100];

            // diziyi rastgele değerlerle doldur
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 21);
            }

            // dizinin ilk 10 elemanını ekrana yazdır
            Console.Write("Dizi: [");
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                    Console.WriteLine(dizi[i] + ", ...]");
                else
                    Console.Write(dizi[i] + ", ");
            }
            
            // kullanıcıdan sayı al
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // sayı dizide kaç kez geçiyor bul ve yazdır
            int sayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                // dizinin i.elemanı kullanıcının girdiği sayıya eşitse
                if (dizi[i] == sayi)    
                    sayac++;
            }
            Console.WriteLine(sayi + " sayısı dizide " + sayac + " kez geçiyor.");
        }
    }
}
