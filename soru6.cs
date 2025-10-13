/*
12/10/2025

Soru 6:

Bir mağaza indirim kampanyası düzenlemektedir. Kullanıcıdan alınan
ürün fiyatı ve kullanıcının üyelik durumuna (üye/üye değil) göre
aşağıdaki indirimleri uygulayın:

- Ürün fiyatı 100 TL'nin üzerindeyse ve kullanıcı üye değilse %5
indirim yapılacaktır.
- Ürün fiyatı 100 TL'nin üzerindeyse ve kullanıcı üye ise %10 indirim
yapılacaktır.
- Ürün fiyatı 50 TL ile 100 TL arasında ise ve kullanıcı üye değilse
hiç indirim yapılmayacaktır.
- Ürün fiyatı 50 TL ile 100 TL arasında ise ve kullanıcı üye ise %5
indirim yapılacaktır.
*/

namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mağazamıza hoş geldiniz.");
            Console.Write("Üye misiniz? (E/H): ");
            string uyelik = Console.ReadLine();
            Console.Write("Ürün fiyatını giriniz: ");
            // ilerde yapılacak bölme işleminin sonucu küsüratlı
            // çıkabilir. Küsüratlı kısımları kaybetmemek için
            // değişkenler double türünde tanımlanmalı.
            double urun_fiyati = Convert.ToDouble(Console.ReadLine());
            double indirimli_fiyat = 0; 

            // Üye ise:
            if (uyelik == "E" || uyelik == "e")
            {
                if (urun_fiyati >= 100)
                    indirimli_fiyat = (urun_fiyati * 90) / 100; // %10 indirim
                else if (urun_fiyati >= 50 && urun_fiyati < 100)
                    indirimli_fiyat = (urun_fiyati * 95) / 100; // %5 indirim
            }
            // Üye değilse:
            else
            {
                if (urun_fiyati >= 100)
                    indirimli_fiyat = (urun_fiyati * 95) / 100; // %5 indirim
                else if (urun_fiyati >= 50 && urun_fiyati < 100)
                    indirimli_fiyat = urun_fiyati; // indirim yok
            }

            Console.WriteLine("İndirimli ürün fiyatı: " + indirimli_fiyat);
        }
    }
}
