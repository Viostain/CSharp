using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya!");
            //Console.Write("Selam");

            //Console.WriteLine("******* YEMEK KATEGORİLERİ ********");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            #endregion
            #region String Değişkenler
            //string
            //Degiskenin_turu degisken_adi:
            //string name;
            //name = "Samet";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Samet";
            //customerSurname = "Şahin";
            //customerPhone = "0543 931 0059";
            //customerEmail = "sametsahin2015@gmail.com";
            //district = "Merkez";
            //city = "Çanakkale";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adres: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90543 900 5959";
            //customerEmail = "deneme@gmail.com";
            //district = "Biga";
            //city = "Çanakkale";
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adres: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");







            #endregion
            #region Int Değişkenler
            //int
            //int number = 24;
            //Console.WriteLine(number);


            int hamburgerPrice = 150;
            int cokePrice = 50;
            int waterPrice = 15;
            int friesPrice = 62;
            int pizzaPrice = 230;
            int lemonadePrice = 35;

            Console.WriteLine("**** Restoran Menü Fiyati ****");
            Console.WriteLine();
            Console.WriteLine("---Hamburger: " + hamburgerPrice);
            Console.WriteLine("---Kola: " + cokePrice);
            Console.WriteLine("---Su: " + waterPrice);
            Console.WriteLine("---Kızartmalar: " + friesPrice);
            Console.WriteLine("---Pizza: " + pizzaPrice);
            Console.WriteLine("---Limonata: " + lemonadePrice);
            Console.WriteLine("*******************************");


            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalhamburgerPrice = 0;
            int totalcokePrice = 0;
            int totalwaterPrice = 0;
            int totalfriesPrice = 0;
            int totalpizzaPrice = 0;
            int totallemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 2;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totalfriesPrice = friesCount * friesPrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalhamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalcokePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalwaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalfriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalpizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totallemonadePrice + "TL");
            Console.WriteLine();

            int totalPrice = totalhamburgerPrice + totalcokePrice + totalwaterPrice + totalfriesPrice + totalpizzaPrice + totallemonadePrice;
            Console.WriteLine("Toplam ödenecek tutar: " + totalPrice);
 
            #endregion


            Console.Read();
            
        }
    }
}
