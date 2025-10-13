/*
12/10/2025

Soru 11:

Kullanıcıdan adını ve saati (0–23 arası tam sayı) girmesini isteyiniz
Girilen saat bilgisine göre ekrana uygun selamlama mesajını
yazdırınız:

Eğer saat 0 ile 11 arasındaysa → “Günaydın [İsim]”
Eğer saat 12 ile 17 arasındaysa → “Tünaydın [İsim]”
Eğer saat 18 ile 23 arasındaysa → “İyi akşamlar [İsim]”
*/

namespace soru11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Saati giriniz (0-23): ");
            int saat = Convert.ToInt32(Console.ReadLine());

            if (saat >= 0 && saat <= 11)
                Console.WriteLine("Günaydın " + isim);
            else if (saat >= 12 && saat <= 17)
                Console.WriteLine("Tünaydın " + isim);
            else if (saat >= 18 && saat <= 23)
                Console.WriteLine("İyi akşamlar " + isim);
            else
                Console.WriteLine("saat beklenen aralıkta değil.");
        }
    }
}

