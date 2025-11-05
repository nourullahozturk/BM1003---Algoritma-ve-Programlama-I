using System.Text;

namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // konsola türkçe karakterler yazdırabilmeyi sağlar
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // kullanıcıdan türkçe karakter almayı sağlar
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // 1. kullanıcıdan dizi uzunluğunu al
            Console.Write("Dizi uzunluğunu giriniz: ");
            int uzunluk = Convert.ToInt32(Console.ReadLine());

            // 2. dizi tanımla
            int[] dizi = new int[uzunluk];

            // 3. diziyi dön ve rastgele sayılar ata    
            Random r = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(1, 101);
            }

            // 4. diziyi dön ve elemanlarını yazdır   
            Console.Write("Üretilen dizi: [");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (i == dizi.Length - 1)
                    Console.WriteLine($"{dizi[i]}]");
                else
                    Console.Write($"{dizi[i]}, ");
            }
            
            // 5.dizinin en büyük ve en küçük sayısını bul
            int en_buyuk = dizi[0]; // veya 1 veya int.MinValue
            int en_kucuk = dizi[0]; // veya 100 veya int.MaxValue
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < en_kucuk)
                    en_kucuk = dizi[i];

                if (dizi[i] > en_buyuk)
                    en_buyuk = dizi[i];
            }
            Console.WriteLine($"Dizinin en büyük elemanı: {en_buyuk}");
            Console.WriteLine($"Dizinin en küçük elemanı: {en_kucuk}");
        }
    }
}
/*
Açıklamalar:

En büyük ve en küçük bulma sorularında En büyük ve en küçük değeri
tutacak değişkenlerin ilk değerini şu şekilde atamalısınız:
En büyük değişkenine --> dizinin herhangi bir elemanı veya
kullanıcının girebileceği minimum değer
En küçük değişkenine --> dizinin herhangi bir elemanı veya 
kullanıcının girebileceği maximum değer

dizinin tüm elemanlarından en büyük veya en küçük olanı bulmak
istediğimiz için elemanlardan birini başlangıçta en büyük/küçük
seçiyoruz. Daha sonra diğer bütün elemanları gezerek en küçük/büyük
değeri sürekli güncelliyoruz.

Aksi takdirde yanlış sonuçlar görülebilir.
*/