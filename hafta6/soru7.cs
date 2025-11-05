namespace Soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktöriyeli hesaplanacak sayıyı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= n; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine($"{n}'in faktöriyeli {faktoriyel}");
        }
    }
}
