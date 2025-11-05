namespace soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan dizide kaç adet sayı olacağı bilgisini al
            Console.Write("Kaç adet sayı üretilsin? ");
            int adet = Convert.ToInt32(Console.ReadLine());
        
            // dizi tanımla
            int[] dizi = new int[adet];
            // dizinin elemanlarını ata, yazdır ve topla
            Random r = new Random();
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(1, 101);
                Console.WriteLine($"{i}.dizi elemanı: {dizi[i]}");
                toplam += dizi[i];
            }
            // dizinin ortalamasını hesapla
            double ortalama = (double)toplam / adet;
            Console.WriteLine($"Dizideki elemanların ortalaması: {ortalama}");

            // 1. Ortalamadan büyük olan elemanları yazdır
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > ortalama)
                    Console.WriteLine($"{i}.dizi elemanı ortalamadan büyüktür: {dizi[i]}");
            }

            // 2. Dizinin elemanlarının ortalamaya uzaklığını yazdır
            // 3. Ortalamaya en yakın elemanı ve indexini bulup yazdırın
            int en_yakin = int.MaxValue;
            int index = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                int uzaklik = Math.Abs(dizi[i] - (int)ortalama);
                Console.WriteLine($"{i}.dizi elemanının ortalamaya uzaklığı: {uzaklik}");

                if (uzaklik < en_yakin)
                {
                    en_yakin = uzaklik;
                    index = i;
                }
            }
            Console.WriteLine($"Dizinin ortalamaya en yakın elemanı {index}.elemandır ve değeri {dizi[index]}'dir.");
        }
    }
}
/*
Açıklamalar:

Ortalama hesaplarken iki tam sayıyı böldüğümüz için küsüratlı sonuç
çıkabilir. Fakat C#'da int türünde iki sayıyı bölerseniz sonuç yine
int olacaktır. Küsüratlı kısımlar kırpılacaktır. küsüratlı kısmı
kaybetmemek için sayılardan birini double türüne çevirdik.
/ işlemine giren sayılardan en az birisi double türünde ise işlemin
sonucu double türünde olacaktır.

Ortalamaya en yakın olan değeri bulma işlemi aslında en küçük değer
bulma işlemidir. Uzaklıkların en küçüğünü bulmaya çalışıyoruz.

Math.Abs() metodu mutlak değer hesaplar.
*/