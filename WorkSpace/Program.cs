using Business.Concrete;
using Entities.Concrete;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            //SelamVer();
            //SelamVer("Ahmet");
            //SelamVer("Muharrem");
            //int sonuc = Topla(3+5);
            //list();

            Person person1 = new Person();
            person1.NationalIdentity = 123; // Kullanıcı kendi TC bilgisini ve ad soyad gibi kişisel bilgilerini değiştirmeli.
            person1.FirstName = "MUHARREM";
            person1.LastName = "GEDİK";
            person1.DateOfBirthYear = 2002;

            Console.WriteLine("\nPtt aracılığı ile MASKE");
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.WriteLine("\nEczane aracılığı ile MASKE");
            PharmacyManager pharmacyManager = new PharmacyManager(new PersonManager());
            pharmacyManager.GiveMask(person1);

            Console.ReadLine();
        }
        private static void list()
        {
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Muharrem";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Demir";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
        }
        static void SelamVer(string isim="Anonim")
        {
            Console.WriteLine("Merhaba "+ isim);
        }
        static int Topla(int sayi1=10,int sayi2 = 1)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam = "+ sonuc);
            return sonuc;
        }
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            Console.WriteLine(tutar * 1.18);
        }
    }
}