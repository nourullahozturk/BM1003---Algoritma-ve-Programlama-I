/*
12/10/2025

Soru 10:

1’den 10’a kadar olan sayıların çarpım tablosunu oluşturunuz.

1 x 1 = 1
1 x 2 = 2
...
10 x 10 = 100
*/

namespace soru10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
                Console.WriteLine();
            }
        }
    }
}