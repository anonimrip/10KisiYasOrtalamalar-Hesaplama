using System;

namespace nothesaplama
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] yazili_notlari = new int[10];
            int topla = 0;
            for (int i = 0; i < yazili_notlari.Length; i++)
            {
                Console.WriteLine(i+". Yaşını Giriniz: ");
                yazili_notlari[i] = Convert.ToInt32(Console.ReadLine());
                topla = topla + yazili_notlari[i];

            }
            Console.WriteLine("Toplamları: " + topla);
            int hesapla = topla / yazili_notlari.Length;
            Console.Write("Yaş Ortalamaları: ");
            Console.Write(hesapla);
        }
    }
}