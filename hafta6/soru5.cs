namespace soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A dizisini tanımla
            int[] A = [1, 2, 3, 4, 5, 6];

            // A dizisini yazdır
            Console.Write("A: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }

            // 0 1 2 3 4 5 --> 0-1, 2-3, 4-5
            for (int i = 0; i < A.Length-1; i+=2)
            {
                int gecici = A[i];
                A[i] = A[i+1];
                A[i+1] = gecici;
            }

            // A dizisini yazdır
            Console.Write("\nA: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
