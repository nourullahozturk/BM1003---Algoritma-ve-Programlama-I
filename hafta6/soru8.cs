namespace soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyel hesaplama programina hosgeldiniz!");
            while (true)
            {

                Console.Write("Faktöriyeli hesaplanacak sayiyi giriniz: ");
                string s = Console.ReadLine();
                int n;
                if (int.TryParse(s, out n))
                {
                    if (n < 0)
                    {
                        Console.WriteLine("Hata: Faktöriyeli alinacak sayi 0'dan küçük olamaz.");
                        Console.WriteLine("Çikmak için c'ye hesaplamaya devam etmek için herhangi bir tusa basiniz: ");
                        if (Console.ReadLine() == "c") break;
                        else continue;
                    }
                    else if (n == 0 || n == 1)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        int faktoriyel = 1;
                        for (int i = n; i > 1; i--)
                            faktoriyel *= i;
                        Console.WriteLine($"{n}! = {faktoriyel}");
                        Console.WriteLine("Çikmak için c'ye hesaplamaya devam etmek için herhangi bir tusa basiniz: ");
                        if (Console.ReadLine() == "c") break;
                        else continue;
                    }
                }
                else
                {
                    Console.WriteLine("Hata: Geçersiz veri formati.");
                    Console.WriteLine("Çikmak için c'ye hesaplamaya devam etmek için herhangi bir tusa basiniz: ");
                    if (Console.ReadLine() == "c") break;
                    else continue;
                }
            }
        }
    }
}
