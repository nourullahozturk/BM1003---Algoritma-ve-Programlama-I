/*
21/10/2025
Soru 4:

5 satır ve 3 sütundan oluşan bir matris (2 boyutlu dizi) oluşturunuz.
Matrisi 1 ile 9 arasında rastgele sayılarla doldurunuz. Matrisi
yazdırın ve ardından her sütunun toplamını ayrı ayrı gösteriniz.

Çıktı:

3 7 2
5 1 6
9 4 8
2 9 1
6 3 7

Sütun toplamları:
Sütun 1: 25
Sütun 2: 24
Sütun 3: 24
*/

namespace soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 boyutlu matris tanımlama
            int[,] matris = new int[5, 3]; 

            // 2 boyutlu dizi dönme
            Random rnd = new Random();
            // Satır-sütun döngüsü:
            for (int i = 0; i < 5; i++) // satır döngüsü
            {
                for (int j = 0; j < 3; j++) // sütun döngüsü
                {
                    matris[i, j] = rnd.Next(1, 10); // i.satırın j.elemanı
                }
            }

            // 2 boyutlu matrisi ekrana yazdırma
            // Satır-sütun döngüsü:
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }

            // her sütun için bütün satırları topla
            int[] toplamlar = new int[3]; // sütun toplamlarını tutacak dizi

            // Sütun-satır döngüsü:
            for (int i = 0; i < 3; i++)   // sütun
            {
                // her sütun için o sütundaki satırları topluyoruz
                // o yüzden satır döngüsü içte.
                for (int j = 0; j < 5; j++) // satır
                {
                    toplamlar[i] += matris[j, i];
                }
            }

            Console.WriteLine("Sütun toplamları: ");
            for (int i = 0; i < toplamlar.Length; i++)
                Console.WriteLine("Sütun " + (i+1) + ": " + toplamlar[i]);
        }
    }
}
/*
Açıklamalar:
1. 2 boyutlu dizileri dönerken oluşturduğumuz döngülerin satır-sütun
veya sütun-satır döngüsü olmaları tamamen diziyi nasıl indekslediğimize
bağlıdır. Mesela matris[i, j] der i'yi 1.boyutu, j'yi 2.boyutu 
indekslemek için kullanırsak i'nin tanımlandığı döngü satır döngüsü,
j'nin tanımlandığı döngü sütun döngüsü olmuş olur. Tam tersi
matris[j, i] yaparsak j nin olduğu döngü satır döngüsü, i nin olduğu
döngü sütun döngüsü olmuş olur.

2.
2 boyutlu bir diziyi satır satır okumak istiyorsan;
    satır-sütun döngüsü yap.
sütun sütun yani yukarıdan aşağı okumak istiyorsan;
    sütun-satır döngüsü yap.
*/