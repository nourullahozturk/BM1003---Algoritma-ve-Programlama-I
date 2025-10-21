/*
12/10/2025

Soru 7:

Kullanıcıdan bir sayı alın; o sayının faktöriyelini hesaplayıp
yazdırın.
*/

namespace soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 1;
            for (int i = n; i > 1; i--)
                toplam *= n;
            Console.WriteLine(n + "! = " + toplam);
        }
    }
}
/*
Ödev: En çok kaç faktöriyele kadar doğru hesaplanır? Neden?
*/