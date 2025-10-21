/*
12/10/2025

Soru 5:

Kullanıcıdan bir sayı alınız. 1’den bu sayıya kadar olan sayıları
aynı satırda, aralarına virgül koyarak yazdırınız.

Giriş: 5 → Çıkış: 1, 2, 3, 4, 5
*/

namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1'den büyük bir tam sayı giriniz: ");
            int ust_sinir = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < ust_sinir; i++)
                Console.Write(i + ", ");
            Console.WriteLine(5);
        }
    }
}
