/*
12/10/2025

Soru 10:

Kullanıcıdan 1-7 arasında bir tamsayı istenmektedir. Bu tam sayıya
göre haftanın ilgili gününü kelime olarak yazdıran programı yazınız
(switch case ile çözünüz). 
*/

namespace soru10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 ile 7 arasında bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz sayı.");
                    break;
            }
        }
    }
}
