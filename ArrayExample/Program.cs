using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            Random r = new Random();
            string s;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(0, 100);
            }

            Console.WriteLine("1. Dizinin En Büyük Değeri\n2. Dizinin En Küçük Değeri\n3. Dizinin Ortalaması\n4. Dizinin 50 ve Üzerindeki Eleman Sayısı");
            Console.Write("Bir Değer Seçiniz (1/2/3/4) : ");
            s = Console.ReadLine();

            switch (s)
            {
                case "1":
                    Console.WriteLine("Dizinin En Büyük Değeri : " + EnBuyukSayi(dizi));
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Dizinin En Küçük Değeri : " + EnKucukSayi(dizi));
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Dizinin Ortalaması : " + OrtalamaBul(dizi));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Dizide 50 ve Üzerinde Şu Kadar Eleman Vardır : " + ElliUzerinde(dizi));
                    Console.ReadLine();
                    break;
            }

            int EnBuyukSayi(int[] sayi)
            {
                int buyuk = sayi[0];

                for (int i = 0; i < sayi.Length; i++)
                {
                    if (buyuk < sayi[i])
                    { buyuk = sayi[i]; }
                }
                return buyuk;
            }

            int EnKucukSayi(int[] sayi)
            {
                int kucuk = sayi[0];

                for (int i = 0; i < sayi.Length; i++)
                {
                    if (kucuk > sayi[i])
                    { kucuk = sayi[i]; }
                }
                return kucuk;
            }

            double OrtalamaBul(int[] sayi)
            {
                int toplam = 0;
                double ortalama = 0;

                for (int i = 0; i < sayi.Length; i++)
                {
                    toplam = toplam + dizi[i];
                }

                ortalama = toplam / 20;
                return ortalama;
            }

            int ElliUzerinde(int[] sayi)
            {
                int sayac = 0;

                for (int i = 0; i < sayi.Length; i++)
                {
                    if (dizi[i] >= 50)
                    {
                        sayac++;
                    }
                }
                return sayac;
            }
        }
    }
}
