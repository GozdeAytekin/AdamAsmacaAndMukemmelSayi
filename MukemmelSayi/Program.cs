using System;

namespace MukemmelSayi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kontrol etmek istediginiz sayiyi girin");
            
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (sayi== toplam )
            {
                Console.WriteLine("Girilen " + sayi + " sayisi Mukemmel sayidir...");
            }
            else
            {
                Console.WriteLine("Girilen "+sayi+" sayisi Mukemmel sayi degildir...");
            }
            Console.ReadKey();
        }
    }
}
/*
    1.Framework, uygulama çatısı olarak çevrilebilmektedir. Yani biz örneğin bir web projesi geliştirirken .Net’in bu durum için geliştirdiği frameworku kullanarak bu işi daha kolay ve daha hızlı geliştiririz. Aynı şekilde .Net core da bir .Net Fw gibi bir çerçeve, bir uygulama çatısıdır. .Net dünyasının trend fw’u  son zamanlarda iş ilanlarında olsun eğitim içeriklerinde olsun daha sık görmeye başladığım .net core diye düşünüyorum. 
    2.Açıkçası daha önce böyle bir normalizasyon gerektirecek bir işle uğraşmadım. 1NF, 2NF.. gibi şeyler duydum ama sadece duydum :/ 
    3.C#, Asp.net, html, js kullanarak web programlamasını yapar, verileri Mssql’de tutarım. 
    4.Udemy, Btk akademi, Youtube gibi platformları kullanırım. Engin demiroğ, murat yücedağ, şadi evren şeker, sadık turan gibi kişileri takip ediyor, çeşitli platformlarda eğitimlerine katılıyorum. 
    5.Bilgisayarda pek fazla oyun oynamam, cities: skylines oynuyorum ara sıra, daha çok arkadaşlarımla mobil oyunlar oynarım, pubg mobile gibi. 

 */
