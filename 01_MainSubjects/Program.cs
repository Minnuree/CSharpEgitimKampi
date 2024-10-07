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
            #region YazdırmaKomutları
            /*
            Console.WriteLine("******  Yemek Kategorileri ******");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            */

            #endregion

            #region StringDeğişkenler
            /*
            string custumerName;
            string custumerSurname;
            string custumerPhone;
            string custumerEmail, district, city;

            custumerName = "Ali";
            custumerSurname = "Çınar";
            custumerPhone = "+90 123 345 78 98";
            custumerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Müşteri: " +custumerName+" "+custumerSurname);
            Console.WriteLine("İletişim: " + custumerPhone);
            Console.WriteLine("Email Adresi: " + custumerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("---------------------------------");
            
            custumerName = "Ayşegül";
            custumerSurname = "Kaya";
            custumerPhone = "+90 400 345 00 24";
            custumerEmail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Müşteri: " + custumerName + " " + custumerSurname);
            Console.WriteLine("İletişim: " + custumerPhone);
            Console.WriteLine("Email Adresi: " + custumerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("---------------------------------");
            */

            #endregion

            #region IntDeğişkenler
            
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("------Kola: " + cokePrice + "TL");
            Console.WriteLine("------Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("------Kızartma: " + friesPrice + "TL");
            Console.WriteLine("------Su: " + waterPrice + "TL");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("------Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("------Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("------Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("------Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("------Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine();

            int totalPrice = totalCokePrice + totalHamburgerPrice + totalFriesPrice + totalLemonadePrice
                + totalPizzaPrice + totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");

            #endregion
            Console.ReadLine();
        }
    }
}
