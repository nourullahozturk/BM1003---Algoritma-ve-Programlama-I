/*
Quiz-3 (Şube-2)

Kullanıcıdan 10 adet tam sayı girişi alarak bir diziye kaydediniz.
Program dizideki pozitif, negatif ve sıfır sayıların kaç adet olduğunu bulup ekrana yazdırsın.

Beklenen Çıktı (örnek):
    Sayı 1: -3
    Sayı 2: 7
    Sayı 3: 0
    Sayı 4: 12
    Sayı 5: -8
    Sayı 6: -1
    Sayı 7: 5
    Sayı 8: 0
    Sayı 9: 4
    Sayı 10: -6
    Pozitif sayı adedi: 4
    Negatif sayı adedi: 4
    Sıfır adedi: 2
*/
namespace Quiz3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitif_adet = 0;
            int negatif_adet = 0;
            int sifir_adet = 0;

            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                // kullanıcıdan sayı al
                Console.Write($"Sayı {i + 1}: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                // sayıyı diziye kaydet
                dizi[i] = sayi;
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > 0)
                {
                    pozitif_adet++;
                }
                else if (dizi[i] < 0)
                {
                    negatif_adet++;
                }
                else
                {
                    sifir_adet++;
                }
            }
            Console.WriteLine($"Pozitif sayı adedi: {pozitif_adet}");
            Console.WriteLine($"Negatif sayı adedi: {negatif_adet}");
            Console.WriteLine($"Sfırı adedi: {sifir_adet}");
        }
    }
}
