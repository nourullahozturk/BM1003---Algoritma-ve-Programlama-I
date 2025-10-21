/*
21/10/2025
Soru 1:

Kullanıcıdan 5 adet tam sayı girmesini isteyen, bu sayıları
bir diziye kaydeden ve ardından dizinin elemanlarının içerisindeki
en küçük sayıyı bulan bir program yazınız. (5 dk)

Örnek Çıktı:
5 adet tam sayı giriniz:
1.sayı: 12
2.sayı: -3
3.sayı: 45
4.sayı: 0
5.sayı: 18
Dizideki en küçük sayı: -3
*/

namespace soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 adet tam sayı giriniz:");
            // dizi tanımla
            int[] dizi = new int[5]; 

            // diziyi doldur
            for(int i = 0; i < dizi.Length; i++)
            {
                Console.Write((i + 1) + ".sayı: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            // dizinin en küçük elemanını bul ve yazdır
            int en_kucuk = int.MaxValue;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < en_kucuk)
                    en_kucuk = dizi[i];
            }
            Console.WriteLine("Dizideki en küçük sayı: "+en_kucuk);
        }
    }
}
/*
Açıklamalar:
1. en_kucuk değişkeninin değerini maksimum int değeri olarak
belirledik. Bunun sebebi, eğer en_kucuk değişkeninin
başlangıç değeri dizinin tüm elemanlarından daha küçük olursa if
koşulunun şartı hiç bir zaman sağlanamayacağı için en_kucuk
değişkeninin değeri değiştirilmez, ilk tanımlandığı değer olarak
kalır. Örneğin en_kucuk değişkeninin değeri başlangıçta 0 olursa ve 
girdiler 1 2 3 4 5 olursa dizinin en küçük değeri 0 olarak yazdırır
ki yanlıştır, 1 olması gerekir. Bu mantıksal hatayı gidermek için
en_kucuk değişkenini kullanıcının girebileceği en büyük sayı yaptık
*/