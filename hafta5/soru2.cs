/*
21/10/2025
Soru 2:

Kullanıcıdan bir tamsayı alarak bu uzunlukta bir dizi
oluşturun, -100 ile 100 arasında rastgele sayılarla doldurun ve
dizideki tek sayıların toplamını ve çift sayıların toplamını ayrı 
ayrı ekrana yazdırın. (10 dk)

Çıktı:
Kaç elemanlı dizi oluşturulsun? 6
Dizi: [12, -5, 33, 0, -44, 7]
Çift sayıların toplamı: -32
Tek sayıların toplamı: 35
 */
namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan dizi uzunluğunu al
            Console.Write("Kaç elemanlı dizi oluşturulsun? ");
            int uzunluk = Convert.ToInt32(Console.ReadLine());
            
            // dizi tanımla
            int[] dizi = new int[uzunluk];
            
            // diziyi rastgele değerlerle doldur
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(-100, 101);
            }

            // diziyi ekrana yazdır
            Console.Write("Dizi: [");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (i == dizi.Length-1)
                    Console.Write(dizi[i] + "]");
                else
                    Console.Write(dizi[i] + ", ");
            }

            // Çift ve Tek sayıların toplamını bul ve yazdır
            int cift_toplam = 0;
            int tek_toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                    cift_toplam += dizi[i];
                else
                    tek_toplam += dizi[i];
            }
            Console.WriteLine("\nÇift sayıların toplamı: " + cift_toplam);
            Console.WriteLine("Tek sayıların toplamı: " + tek_toplam);
        }
    }
}
/*
Ödev: Yukarıdaki kodda her bir aşama için ayrı bir for döngüsü
kullanıldı. Bütün aşamaları tek bir for döngüsü içinde yapacak
şekilde kodu düzenleyiniz.
*/