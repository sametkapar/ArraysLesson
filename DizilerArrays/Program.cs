using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DizilerArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            //Aynı türden verileri belirli bir index(sıra) numarası ile bir arada tutmaya yarayan sistemlere Arrays(dizi) denir.
            #endregion

            #region Nedir?

            ////int elemansayi = 20;
            ////int[] sayiları2 =new int[elemansayi];
            //int[] sayilar = new int[10]; //Ram'de integer türünden veri alabilen 10 adet değişken oluşturduk.
            //Console.WriteLine(sayilar.Length);
            //sayilar[5] = 30;
            //sayilar[2] = 55;
            //sayilar[3] = 75;
            //sayilar[7] = 31;
            //sayilar[9] = -3200;
            ////sayilar[10] = 22; Dizinin 10. index'i olmadığı için IndexOutOfRange hatası alınır.

            //Console.WriteLine(sayilar[7]);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion

            #region Dizi Oluşturma Teknikleri
            //string[] isimler = new string[5];
            //isimler[0] = "Batuhan";
            //isimler[1] = "Burak";
            //isimler[2] = "Samet";
            //isimler[3] = "Mevlüt";
            //isimler[4] = "Alp";

            //string[] names = { "Batuthan", "Burak", "Samet", "Mevlüt", "Alp" };
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i] + " ");
            //    //Console.Write($"{names[i]} ");
            //    //Console.Write("{0} {1}\n", i + 1, names[i]);
            //}
            //Console.WriteLine();

            #endregion

            #region Konsoldan 5 isim kaydedip yazdırınız

            //string[] isimler = new string[5];
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("İsim giriniz");
            //    isimler[i]=Console.ReadLine();
            //}
            //Console.Clear();
            //Console.WriteLine("Katılımcılar");
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            #endregion

            int[] sayilar = { 12, 25, 43, -20, 65, 1, 9, 15, 25, 65, -86, -4300, 123, 45, 12 };
            #region Dizi içerisindeki negatif sayıları yazdırınız

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            #endregion

            #region Dizi içerisindeki çift sayıları yazdırınız

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            #endregion

            #region Dizi içerisindeki sayıların ortalamasını buldurunuz -ÖDEV


            #endregion

            #region dizi içerisindeki çift sayıların ortalamasını bulunuz - ÖDEV

            #endregion

            #region Dizi içerisindeki pozitif sayıların adetini yazdırın - ÖDEV

            #endregion

            #region Dizi içerisindeki en büyük sayıyı yazdırınız
            //int enbuyuk = sayilar[0];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if(sayilar[i] > enbuyuk)
            //    {
            //        enbuyuk = sayilar[i];
            //    }
            //}
            //Console.WriteLine("En Büyük Sayı = " + enbuyuk);
            #endregion

            #region Dizi içerisindeki en küçük sayıyı bulunuz - ÖDEV

            #endregion

            #region Dizi içerisindeki en büyük sayı ile en küçük sayının yerini değiştiriniz - ÖDEV

            #endregion

            string[] urunler = { "Domaets", "Biber", "Soğan", "Yumurta", "Süt  ", "Ekmek" };
            double[] fiyatlar = { 48.5, 63, 9, 25, 4.25, 38, 12 };

            #region Menü Listeleyiniz

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + urunler[i] + "\t" + fiyatlar[i] + "\tTL");

            }
            #endregion

            #region Adet Sormalı Ürün Satın aldırma

            Console.WriteLine("Kaç kalem ürün alacaksın?");
            int alinacakadet = Convert.ToInt32(Console.ReadLine());
            double toplam = 0;
            for (int i = 0; i < alinacakadet; i++) 
            {
                Console.WriteLine("Almak istediğininiz ürünün numarısını giriniz. ");
                int urunno = Convert.ToInt32(Console.ReadLine());
                int index = urunno - 1;
                toplam += fiyatlar[index];
            }
            Console.WriteLine("Teşekkür ederiz");
            Console.WriteLine("TOPLAM = " + toplam + " TL");
            #endregion

            #region  ÖDEV
             //başlangıçta adet sormadan ürün satın aldırma
             //başlangıçta adet sormadan ve her ürün seçildikten bu üründen kaç adet alacaksın
             //kaç adet domates alacaksın şejklinde ürün adı ile ürün satın aldırma
             //kaç kg domates alacaksın kaç adet ekmek alacaksın kaç LT süt alacaksın

            #endregion

        }
    }
}
