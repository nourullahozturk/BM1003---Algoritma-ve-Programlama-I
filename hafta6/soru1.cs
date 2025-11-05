namespace soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Kullanıcıdan yolcu isimlerini ve koltuk numaralarını al
            Console.Write("Birinci yolcunun adını girin: ");
            string yolcu1 = Console.ReadLine();

            Console.Write($"{yolcu1}'nin koltuk numarasını girin: ");
            int koltuk1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nİkinci yolcunun adını girin: ");
            string yolcu2 = Console.ReadLine();

            Console.Write($"{yolcu2}'nin koltuk numarasını girin: ");
            int koltuk2 = Convert.ToInt32(Console.ReadLine());

            // 2. Değişimden önceki durumu göster
            Console.WriteLine("\nDeğişimden önce:");
            Console.WriteLine($"{yolcu1} - Koltuk {koltuk1}");
            Console.WriteLine($"{yolcu2} - Koltuk {koltuk2}");

            // 3. Koltuk numaralarını değiştir
            int gecici = koltuk1;
            koltuk1 = koltuk2;
            koltuk2 = gecici;

            // 4. Değişimden sonraki durumu göster
            Console.WriteLine("\nDeğişimden sonra:");
            Console.WriteLine($"{yolcu1} - Koltuk {koltuk1}");
            Console.WriteLine($"{yolcu2} - Koltuk {koltuk2}");
        }
    }
}
