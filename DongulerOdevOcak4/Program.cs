using System;

//1'den 10'a kadar olan sayıları ekrana yazdıran bir for döngüsü
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}

// Kullanıcıdan alınan bir sayıya kadar olan sayıların toplamını hesaplayan program

//class Program
//{
//    static void Main()
//    {
//        int sayi = 0;
//        int toplam = 0;
//        bool gecerliGiris = false;

//        while (!gecerliGiris)
//        {
//            Console.Write("Lütfen pozitif bir tam sayı giriniz: ");

//            if (int.TryParse(Console.ReadLine(), out sayi) && sayi > 0)
//            {
//                gecerliGiris = true;
//            }
//            else
//            {
//                Console.WriteLine("Geçersiz giriş! Pozitif bir tam sayı girmelisiniz.");
//            }
//        }

//        for (int i = 1; i <= sayi; i++)
//        {
//            toplam += i;
//        }

//        Console.WriteLine($"1'den {sayi}'ye kadar olan sayıların toplamı: {toplam}");

//        int formulToplam = sayi * (sayi + 1) / 2;
//        Console.WriteLine($"Formül ile hesaplanan toplam (kontrol): {formulToplam}");
//    }
//}