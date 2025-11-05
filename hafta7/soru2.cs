namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A dizisini tanımla
            int[] A = [1, 2, 3, 4, 5, 6];

            // A dizisini yazdır
            Console.Write("A: [");
            for (int i = 0; i < A.Length; i++)
            {
                if (i == A.Length-1)
                    Console.WriteLine(A[i] + "]");
                else
                    Console.Write(A[i] + ", ");
            }

            // A dizisini tersine çevir (elemanların yerlerini değiştirerek)
            // 0 1 2 3 4 5 --> 0-5, 1-4, 2-3
            // 0 1 2 3 4 --> 0-4, 1-3, 2-2
            for (int i = 0; i < A.Length/2; i++)
            {
                int gecici = A[i];
                A[i] = A[(A.Length-1)-i];
                A[(A.Length - 1) - i] = gecici;
            }

            // B dizisini yazdır
            Console.Write("\nB: [");
            for (int i = 0; i < A.Length; i++)
            {
                if (i == A.Length - 1)
                    Console.WriteLine(A[i] + "]");
                else
                    Console.Write(A[i] + ", ");
            }
        }
    }
}
