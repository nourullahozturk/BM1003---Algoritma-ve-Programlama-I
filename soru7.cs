/*
12/10/2025

Soru 7:

Kullanıcıdan iki sayı ve işlem türü (+, -, *, /, %) alınsın. İşleme
göre sonucu bulan programı if/else yapısını kullanarak yazınız.
*/

namespace soru7
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
            if (islem == "+")
                sonuc = sayi1 + sayi2;
            else if (islem == "-")
                sonuc = sayi1 - sayi2;
            else if (islem == "*")
                sonuc = sayi1 * sayi2;
            else if (islem == "/")
                // sayi1 ve sayi2'yi double türünde tanımlamak yerine
                // bölme işlemine giren sayılardan birini double türüne
                // çevirirsek işlem geriye küsüratlı bir sayı döndürecektir.
                sonuc = Convert.ToDouble(sayi1) / sayi2;
            else
                Console.WriteLine("Geçersiz işlem");
            
            Console.WriteLine(sayi1 + " " + islem + " " + sayi2 + " işleminin sonucu: " + sonuc);
        }
    }
}
