namespace Quiz2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac3 = 0;
            int sayac5 = 0;
            int sayac3ve5 = 0;

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 3 == 0)
                {
                    sayac3++;
                }
                if (i % 5 == 0)
                {
                    sayac5++;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sayac3ve5++;
                }
            }
            Console.WriteLine("3'ün katı olanlar: " + sayac3);
            Console.WriteLine("5'in katı olanlar: " + sayac5);
            Console.WriteLine("Hem 3 hem 5'in katı olanlar: " + sayac3ve5);
        }
    }
}
