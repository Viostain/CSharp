using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice,orangePrice,strawberryPrice,potatoPrice,tomatoPrice;
            //applePrice = 5.85;
            //orangePrice = 10.29;
            //strawberryPrice = 23.33;
            //potatoPrice = 6.88;
            //tomatoPrice = 3.99;
            //Console.WriteLine("---Elma birim fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---Portakal birim fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---Çilek birim fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---Patates birim fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---Domates birim fiyatı: " + tomatoPrice + "  TL");

            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 3.260;
            //strawberryGram = 0.750;
            //potatoGram = 4;
            //tomatoGram = 2.566;

            //double appleTotalPrice= applePrice * appleGram;
            //double orangeTotalPrice= orangePrice * orangeGram;
            //double strawberryTotalPrice= strawberryPrice * strawberryGram;
            //double potatoTotalPrice= potatoPrice * potatoGram;
            //double tomatoTotalPrice= tomatoPrice * tomatoGram;

            //Console.WriteLine("*********************************************************");
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam tutar: " + appleTotalPrice);
            //Console.WriteLine("*********************************************************");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam tutar: " + orangeTotalPrice);
            //Console.WriteLine("*********************************************************");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam tutar: " + strawberryTotalPrice);
            //Console.WriteLine("*********************************************************");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam tutar: " + potatoTotalPrice);
            //Console.WriteLine("*********************************************************");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam tutar: " + tomatoTotalPrice);
            //Console.WriteLine("*********************************************************");
            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş toplam tutar: " + totalPrice + "TL");
            #endregion
            #region Char Değişkenler

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);
            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName,passengerSurname,passengerAge,passengerPhone,passengerDistrict,passengerCity,passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Telefon No: ");
            //passengerPhone = Console.ReadLine();
            //Console.Write("TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcunun TC Kimlik No:" + passengerIdentityNumber +
            //    "- Yolcu Ad Soyad: "+ passengerName + 
            //    " " + passengerSurname + 
            //    " Yaş: " + passengerAge + " İletişim:" + passengerPhone +
            //    " " + passengerDistrict + 
            //    "/" +passengerCity);

            #endregion
            #region Klavye Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 2000;
            //computerPrice = 1700;
            //chairPrice = 5000;
            //tvPrice = 35000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount = int.Parse( Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz:");
            //tvCount = int.Parse( Console.ReadLine());

            //int totalPrice = shoesCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);



            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.sınav notunu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion
            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz:");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);

            #endregion
            Console.Read();
        }
    }
}
