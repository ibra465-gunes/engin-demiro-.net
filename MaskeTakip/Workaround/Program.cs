using System;
using System.Collections.Generic;
namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler();
            Vatandas vatandas = new Vatandas();
            Program.SelamVer("Engin");
            SelamVer();
            int sonuc = Topla(3,5);
            //Diziler Arrays
            string[] student = new string[] {"Engin","Kerem","Berkay"};
            /*student[0]="Engin;
             * student[0]="Kerem;
             * student[0]="Berkay;
             */
            foreach (var item in student)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine(student[i]);
            }
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.Write(sayi2);
            List<string> yenSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yenSehirler1.Add("Adana 1");
            foreach (var item in yenSehirler1)
            {
                Console.WriteLine(item);
            }
            PttManager pttManager = new PttManager();
            Console.ReadLine();
        }

        static int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Topla : "+sonuc);
            return sonuc;
        }
        //Alttaki parametre yapısı eğer alttaki method
        //çağrılırsa ve parametre girilmez ise default
        //olarak isimsiz parametresinin girilmesini sağlar.
        static void SelamVer(string name="isimsiz")
        {
            Console.WriteLine("Merhaba"+" "+name);
        }

        private static void Değişkenler()
        {
            string message = "Selam";
            double amount = 10000.0;
            int sayi = 10;
            bool girisYapmisMi = false;

            Console.WriteLine(message);
            Console.WriteLine(amount);
        }
    }
    public class Vatandas
    {   //Classın atrebütlerine erişim belirleyici vermez
        //isek dşarıdan bu değişkenlere erişim sağlayamayız.
        //Bu değişkenlere dışarıdan erişebilmek için public vermeliyiz.
        //Classlar ve methodlar pascal casing yazılır.
        private string Ad{  get; set; }
        private string Soyad { get; set; }
        private int DogumYili { get; set;}
        private long TcNo { get; set; }
    }
}
