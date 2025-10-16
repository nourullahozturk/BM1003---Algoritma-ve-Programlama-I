namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // promptlar, değişken tanımlama ve girdi alma
            Console.Write("Plan türünü giriniz (Basic/Plus/Pro): ");
            string plan_turu = Console.ReadLine();
            Console.Write("Abonelik süresini (ay) giriniz: ");
            int abonelik_suresi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Öğrenci misiniz? (E/H): ");
            string ogrencilik = Console.ReadLine();

            // toplam ücret değişken tanımı 
            double toplam_ucret = 0;
            // toplam ücret hesapla
            if (plan_turu == "Basic")
                toplam_ucret = 120;
            else if (plan_turu == "Plus")
                toplam_ucret = 170;
            else
                toplam_ucret = 250;

            // İndirimleri uygula
            if (abonelik_suresi >= 12)
                toplam_ucret = (toplam_ucret * 90) / 100;
            if (ogrencilik == "E")
                toplam_ucret = (toplam_ucret * 95) / 100;

            // kurulum ücretini ekle
            if (abonelik_suresi < 12)
                toplam_ucret += 60;

            // Çıktı gösterme, string birleştirme
            Console.Write("Toplam otopark ücreti: " + toplam_ucret);
        }
    }
}
