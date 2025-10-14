/*
12/10/2025

Soru 1:

Kullanıcıdan iki sayı alın (örneğin 3 ve 9). Bu iki sayı dahil olmak
üzere aradaki sayıların toplamını bulan programı yazınız.

Beklenen çıktı: 3 + 4 + 5 + 6 + 7 + 8 + 9 = 42
*/
namespace soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alt sınır olacak bir tam sayi giriniz: ");
            int alt_sinir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üst sınır olacak bir tam sayi giriniz: ");
            int ust_sinir = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            for (int i = alt_sinir; i <= ust_sinir; i++)
                toplam += i;
            Console.WriteLine(alt_sinir + " ile " + ust_sinir +
                " arasındaki sayıların toplamı: " + toplam);
        }
    }
}
