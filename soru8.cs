/*
12/10/2025

Soru 8:

Kullanıcıdan iki sayı ve işlem türü (+, -, *, /, %) alınsın. İşleme
göre sonucu bulan programı switch-case yapısını kullanarak yazınız.
*/

namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basit hesap makinesi programına hoşgeldiniz.");
            Console.Write("Yapmak istediğiniz işlemi giriniz (+,-,*,/): ");
            string islem = Console.ReadLine();
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            double sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = Convert.ToDouble(sayi1) / sayi2;
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem");
                    break;
            }
            Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " işleminin sonucu: " + sonuc);
        }
    }
}
