/*
8/10/2025

Soru 1:

Bir dairenin yarıçapını girdi olarak alan ve dairenin çevresini ve
alanını hesaplayan programı yazın.
*/

namespace soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const double PI = 3.14;
            Console.Write("dairenin yarıçapını giriniz: ");
            double r = Convert.ToDouble(Console.ReadLine()); // girdi al, double'a çevir, değişkene ata
            double alan = Math.PI * r * r; 
            double cevre = 2 * Math.PI * r;
            Console.WriteLine("alan: " + alan + " çevre: " + cevre);
        }
    }
}

/*
Açıklamalar:

1. Console.WriteLine() fonksiyonu argüman olarak aldığı mesajı konsol
ekranına yazdıktan sonra alt satıra geçerken Console.Write() alt
satıra geçmez.

2. const kelimesi ile bir değişken tanımlandığında o değişkenin
değeri sonradan değiştirilemez. değişken değil, sabit olur. Pi 
sayısını kod içerisinde asla değiştirmeyeceğimiz için const ile
tanımlamak daha uygun olacaktır.

3. Pi sayısını kendimiz tanımlamak yerine Math.PI ile Math
kütüphanesindeki pi sayısını da kullanabiliriz.

Ödev: Math.PI ifadesindeki PI üzerine mouse'u sürüklediğinizde
editörün açıklaması görülecektir. PI sayısının nasıl tanımlandığını
inceleyiniz.
*/