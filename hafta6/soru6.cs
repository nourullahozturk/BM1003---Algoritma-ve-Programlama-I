namespace soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir yazı giriniz: ");
            string yazi = Console.ReadLine();

            Console.Write("Girilen yazının tersi: ");
            for (int i = yazi.Length-1; i >= 0; i--)
                Console.Write(yazi[i]);
        }
    }
}
