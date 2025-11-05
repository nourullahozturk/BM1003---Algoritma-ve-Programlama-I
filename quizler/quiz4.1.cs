/*
Quiz-4 – Şube 1

Kullanıcıdan bir pozitif tam sayı alınız.
Program, 1 ile girilen sayı arasında bulunan tüm asal sayıları ekrana yazdırsın.

Tanım: Asal sayı; yalnızca 1 ve kendisine tam bölünebilen, 1’den büyük doğal sayıdır.

Beklenen Çıktı (örnek):

Kaça kadar asal sayılar listelensin?: 20
Asal sayılar:
2 3 5 7 11 13 17 19
*/
namespace Quiz4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaça kadar asal sayılar listelensin?: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Asal sayılar:");
            bool asal_mi = false;
            for (int i = 0; i < n; i++) // n'ye kadar olan her sayı için
            {
                for (int j = 2; j < i; j++) // asallık kontrolü yap
                {
                    if (i % j == 0) // kalansız bölen var, sıradaki sayıya geç
                    {
                        asal_mi = false;
                        break;
                    }
                    asal_mi = true;
                }

                if (asal_mi || i == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
