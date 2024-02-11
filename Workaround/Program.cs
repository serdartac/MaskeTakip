using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SelamVer(isim:"Engin");
            SelamVer(isim:"Ahmet");
            SelamVer(isim:"Ayşe");
            SelamVer();

            int sonuc = Topla(6,58);

            //Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
           
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";
            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            Console.WriteLine("-------------------------");

            Person person1 = new Person();
            person1.FirstName = "Serdar";
            person1.LastName = "Taç";
            person1.DateOfBirthYear = 1234;
            person1.NationalIdentity = 12345678910;


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine("-------------------------");

            List<string> yeniSehirler1 = new List<string> { "Ankara","İstanbul","İzmir"};
            yeniSehirler1.Add("Bursa");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " +isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " +sonuc);
            return sonuc;
        }

    }
}
