using System;
using System.Collections.Generic;

partial class Program
{
    static void Main()
    {
        // 1. 10 adet tam sayi verisi alacak bir dizi tanimlama
        int[] sayilar = new int[10];

        // 2. diziyi doldur ve ekrana yazdir
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write("Sayı {0}: ", i + 1);
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Girdiğiniz sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        // 3. diziye kullanicidan alinan degeri ekleme
        Console.Write("Yeni bir sayı girin: ");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());
        List<int> sayilarListesi = new List<int>(sayilar);
        sayilarListesi.Add(yeniSayi);

        // 4. diziyi buyukten kucuge siralama
        sayilarListesi.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine("Büyükten küçüğe sıralanmış sayılar:");
        foreach (int sayi in sayilarListesi)
        {
            Console.WriteLine(sayi);
}
 
            Console.ReadKey();
    }
}