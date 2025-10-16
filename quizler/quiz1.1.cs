namespace Quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // promptlar, değişken tanımlama ve girdi alma
            Console.Write("Araç türünü giriniz (otomobil/motosiklet/kamyonet): ");
            string arac_turu = Console.ReadLine();
            Console.Write("Kalış süresini (saat) giriniz: ");
            int kalis_suresi = Convert.ToInt32(Console.ReadLine());

            // toplam ücret değişken tanımı
            double toplam_ucret = 0;
            // toplam ücret hesapla
            if (arac_turu == "otomobil")
                toplam_ucret = 25 * kalis_suresi;
            else if (arac_turu == "motosiklet")
                toplam_ucret = 15 * kalis_suresi;
            else
                toplam_ucret = 35 * kalis_suresi;

            // İndirim uygula
            if (kalis_suresi >= 8)
                toplam_ucret = (toplam_ucret * 85) / 100;

            // Fiyat sabitle
            if (toplam_ucret < 20)
                toplam_ucret = 20;

            // Çıktı gösterme, string birleştirme
            Console.Write("Toplam otopark ücreti: " + toplam_ucret);
        }
    }
}
