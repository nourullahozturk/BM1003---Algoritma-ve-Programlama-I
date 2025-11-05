namespace Quiz2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int elliden_buyuk = 0;
            int rastgele_sayi = 0;
            Console.Write("Üretilen sayılar: ");
            for (int i = 0; i < 20; i++)
            {
                rastgele_sayi = rnd.Next(1, 100);
                Console.Write(rastgele_sayi+" ");

                if (rastgele_sayi > 50) elliden_buyuk++;
            }
            Console.WriteLine("\n50'den büyük sayı adedi: " + elliden_buyuk);
        }
    }
}
