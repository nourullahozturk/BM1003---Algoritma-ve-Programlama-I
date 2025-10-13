/*
8/10/2025

Soru 2:

Klavyeden girilen 3 basamaklı pozitif tam sayının yüzler basamağı,
onlar basamağı ve birler basamağını ayrıştıran programı yazınız. 

Ekran çıktısı: 345 sayısının yüzler basamağı 3, onlar basamağı 4,
birler basamağı 5’tir.
*/

namespace soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üç basamaklı bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int yuzler = (sayi / 100) % 10;
            int onlar = (sayi / 10) % 10;
            int birler = (sayi / 1) % 10;
            Console.WriteLine("yüzler basamağı:" + yuzler +
                "\nonlar basamağı:" + onlar +
                "\nbirler basamağı:" + birler);
        }
    }
}

/*
Açıklamalar:

1. Çözüm algoritması: sayıyı 10'un katlarına bölerek hangi
basamaktaki rakamı istiyorsak o basamağı birler basamağına
getiriyoruz. Daha sonra mod 10 işlemi yapıp birler basamağındaki
sayıyı alıyoruz.

örneğin 5 basamaklı 34567 sayısı için:
34567 / 10000 --> 3.4567 mod 10 --> 3 (onbinler basamağındaki rakam)
34567 / 1000 --> 34.567 mod 10 --> 4 (binler basamağındaki rakam)
34567 / 100 --> 345.67 mod 10 --> 5 (yüzler basamağındaki rakam)
34567 / 10 --> 3456.7 mod 10 --> 6 (onlar basamağındaki rakam)
34567 / 1 --> 34567 mod 10 --> 7 (birler basamağındaki rakam)

2. Console.WriteLine() içindeki stringlerde kullanılan "\n" karakteri
özel bir karakter dir. newline karakteri Alt satıra geçmeyi sağlar.

Ödev: Özel karakterler hk. açıklamaların olduğu link aşağıda
verilmiştir. Diğer özel karakterleri inceleyiniz.
https://www.w3schools.com/cs/cs_strings_chars.php
*/