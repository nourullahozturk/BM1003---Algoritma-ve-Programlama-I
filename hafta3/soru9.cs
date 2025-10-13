/*
12/10/2025

Soru 9:

Kullanıcıdan 1-7 arasında bir tamsayı istenmektedir. Bu tam sayıya
göre haftanın ilgili gününü kelime olarak yazdıran programı yazınız
(if/else ile çözünüz). 
*/

namespace soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 ile 7 arasında bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 1)
                Console.WriteLine("Pazartesi");
            else if (sayi == 2)
                Console.WriteLine("Salı");
            else if (sayi == 3)
                Console.WriteLine("Çarşamba");
            else if (sayi == 4)
                Console.WriteLine("Perşembe");
            else if (sayi == 5)
                Console.WriteLine("Cuma");
            else if (sayi == 6)
                Console.WriteLine("Cumartesi");
            else if (sayi == 7)
                Console.WriteLine("Pazar");
            else
                Console.WriteLine("Geçersiz sayı.");
        }
    }
}
