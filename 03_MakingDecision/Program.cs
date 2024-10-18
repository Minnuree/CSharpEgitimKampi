using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            /*
            string password;

            Console.Write("Lütfen şifreyi giriniz: ");
            password = Console.ReadLine();
            Console.WriteLine();

            if(password == "abc")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış!!!");
            }
           

            string capital, country;

            Console.Write("Başkent giriniz: ");
            capital = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ülke giriniz: ");
            country = Console.ReadLine();
            Console.WriteLine();

            if (capital=="ankara" & country=="türkiye")
            {
                Console.Write("Veriler Doğrulandı");
            }
            else
            {
                Console.Write("Hatalı Bilgi");
            }
           

            int number;

            Console.Write("Sayıyı giriniz: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(number == 5)
            {
                Console.WriteLine("Sayı Doğru");
            }
            else
            {
                Console.WriteLine("Sayı Hatalı");
            }
            

            int exam1, exam2, exam3, average;
            string result ="Hata!";

            Console.Write("1. Sınav Notu: ");
            exam1 =int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("2. Sınav Notu: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("3. Sınav Notu: ");
            exam3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların Ortalaması: " + average);

            if(average > 0 & average <=50)
            {
                result = "Sonuç vasat";
            }
            if(average >50 & average<= 70)
            {
                result = "Sonuç orta";
            }
            if(average >70 & average<= 84)
            {
                result = "Sonuç iyi";
            }
            if (average > 84 & average <= 100)
            {
                result = "Sonuç çok iyi";
            }

            Console.WriteLine(result);


            string city;

            Console.Write("lütfen şehir girişi yapınız: ");
            city = Console.ReadLine();
            Console.WriteLine();

            if(city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("Şehir mevcut.");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil.");
            }

            string userName;

            Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            userName = Console.ReadLine();
            Console.WriteLine();

            if ( userName != "admin")
            {
                Console.Write("Bu kullanıcı adı kabul edilemez.");
            }
            else
            {
                Console.Write("Hoş geldiniz.");
            }
*/




            #endregion

            #region Mod İşlemleri

            /*
            int number;
            number = 26;

            int result = number % 5;
            Console.WriteLine(result);
            

            Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;

            Console.Write("1. Sayının 2. Sayıya bölümünden kalan: " +result);


            Console.Write("Lütfen sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.Write("Çift Sayıdır.");
            }
            else
            {
                Console.Write("Tek sayıdır.");
            }*/
            #endregion
            #region Char değişkenler ile Karar Yapıları
            /*
            Console.Write("Lütfen takım sembolünü giriniz: ");
            char team = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if( team =='g' | team =='G')
            {
                Console.Write("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }
            */

            #endregion

            #region Örnek Proje Uygulaması
            /*
            Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("---------------------");
            Console.WriteLine();


            string menuItem;

            Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if( menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Ana Yemekler ----------");
                Console.WriteLine();
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("---------- Ana Yemekler ----------");

                Console.WriteLine();


            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Çorbalar ----------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin");
                Console.WriteLine("---------- Çorbalar ----------");

                Console.WriteLine();


            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Pizzalar ----------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margaritha");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine("---------- Pizzalar ----------");

                Console.WriteLine();


            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("---------- İçecekler ----------");
                Console.WriteLine();
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Su");
                Console.WriteLine("---------- İçecekler ----------");

                Console.WriteLine();


            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Tatlılar ----------");
                Console.WriteLine();
                Console.WriteLine("1-Triliçe");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Sütlaç");
                Console.WriteLine("---------- Tatlılar ----------");

                Console.WriteLine();

            }
            */

            #endregion

            #region Switch Case

            /*
            Console.Write("Lütfen ay girişi yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());


            switch (monthNumber )
            {
                case 1: Console.Write("Ocak");break;
                case 2: Console.Write("Şubat");break;
                case 3: Console.Write("Mart");break;
                case 4: Console.Write("Nisan");break;
                case 5: Console.Write("Mayıs");break;
                case 6: Console.Write("Haziran");break;
                case 7: Console.Write("Temmuz");break;
                case 8: Console.Write("Ağustos");break;
                case 9: Console.Write("Eylül");break;
                case 10: Console.Write("Ekim");break;
                case 11: Console.Write("Kasım");break;
                case 12: Console.Write("Aralık");break;
                default: Console.Write("Hatalı Veri Girişi");break;

            }
            */

            #endregion

            #region Switch Case Hesap Makinesi

            /*
            int number1, number2, result;

            Console.Write("Birinci Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            char symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+': result = number1 + number2;
                         Console.Write("Toplam: " +result); break;
                case '-': result = number1 - number2;
                    Console.Write("Fark: " +result); break;
                case '*':result = number1 * number2;
                    Console.Write("Çarpım: " +result); break;
                case '/': result = number1 / number2;
                    Console.Write("Bölüm: " +result); break;
                default: Console.Write("Yanlış Sembol Girildi.");break;
            }
            */

            #endregion




            Console.Read();

        }
    }
}
