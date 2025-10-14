/*
12/10/2025

Soru 2:

Kullanıcıdan bir sayı alın. Bu sayıdan 0’a kadar geriye doğru sayın.
Ancak 3’e gelindiğinde “geri sayım durdu” yazıp break komutuyla
döngüyü sonlandırın.

Giriş: 6  
6  
5  
4  
Geri sayım durdu
*/

namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3'ten büyük bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi; i > 0; i--)
            {
                if (i == 3) {
                    Console.WriteLine("Geri sayım durdu.");
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
