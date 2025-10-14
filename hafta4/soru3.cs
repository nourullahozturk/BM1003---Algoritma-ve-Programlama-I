/*
12/10/2025

Soru 3:

Kullanıcıdan satır sayısı isteyin. Girilen değere göre aşağıdaki gibi
bir sayı piramidi oluşturun:

1
12
123
1234
12345
*/

namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Satır sayısı giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= satir; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();    // yeni satıra geç
            }
        }
    }
}