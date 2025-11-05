namespace yeniSoru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N girin: ");
            int N = Convert.ToInt32(Console.ReadLine());
            // 2-boyutlu dizi (matris) tanımla
            int[,] matris = new int[N, N];
            // diziyi -9 ile +9 arasında rastgele sayılarla doldur
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matris[i, j] = r.Next(-9, 10);
                }
            }

            // matrisi ekrana yazdır
            Console.WriteLine("\nOluşturulan matris: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matris[i, j] < 0)
                        Console.Write(matris[i, j] + " ");
                    else
                        Console.Write(" " + matris[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Asal köşegen (soldan sağa) elamanların toplamı ve sonucun yazdırılması
            int asal_kosegen_toplam = 0;
            Console.Write("\nAsal köşegen toplamı: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        asal_kosegen_toplam += matris[i, j];
                        if (i == N - 1)
                        {
                            if (matris[i, j] < 0)
                                Console.WriteLine("(" + matris[i, j] + ")" + " = " + asal_kosegen_toplam);
                            else
                                Console.WriteLine(matris[i, j] + " = " + asal_kosegen_toplam);
                        }
                        else
                        {
                            if (matris[i, j] < 0)
                                Console.Write("(" + matris[i, j] + ")" + " + ");
                            else
                                Console.Write(matris[i, j] + " + ");
                        }
                    }
                }
            }

            // Yardımcı köşegen (sağdan sola) elamanların çarpımı ve sonucun yazdırılması
            int yardimci_kosegen_carpim = 1;
            Console.Write("\nYardımcı köşegen çarpımı: ");
            for (int i = 0; i < N; i++)
            {
                yardimci_kosegen_carpim *= matris[i, N-1-i];
                if (i == N - 1)
                {
                    if (matris[i, N - 1 - i] < 0)
                        Console.WriteLine("(" + matris[i, N - 1 - i] + ")" + " = " + yardimci_kosegen_carpim);
                    else
                        Console.WriteLine(matris[i, N - 1 - i] + " = " + yardimci_kosegen_carpim);
                }
                else
                {
                    if (matris[i, N - 1 - i] < 0)
                        Console.Write("(" + matris[i, N - 1 - i] + ")" + " * ");
                    else
                        Console.Write(matris[i, N - 1 - i] + " * ");
                }
            }
            

            // negatif sayı sayma
            int negatif_sayac = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matris[i, j] < 0)
                        negatif_sayac++;
                }
            }
            Console.WriteLine("\nNegatif sayı adedi: " + negatif_sayac);

        }
    }
}
