using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        //Degiskenler();

        Vatandas vatandas1 = new Vatandas();

        SelamVer("Berkay");
        SelamVer("Faruk");
        SelamVer("Murat");
        SelamVer();

        int sonuc = Topla(6,8);
        int sonuc2 = Topla();

        //Diziler-Arrays

        string ogrenci1 = "Engin";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Berkay";

        Console.WriteLine(ogrenci1);
        Console.WriteLine(ogrenci2);
        Console.WriteLine(ogrenci3);

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        ogrenciler = new string[4];
        ogrenciler[0] = "İlker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        Person person1 = new Person();
        person1.FirstName = "Engin";
        person1.LastNAme = "DEMİROĞ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentitiy = 123;
        
        Person person2 = new Person();
        person2.FirstName = "Berkay";
        

        string[] sehirler1 = new[] {"Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] {"Bursa", "Antalya", "Diyarbakır" };
        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string> {"Ankara", "İstanbul", "İzmir" };
        yeniSehirler1.Add("Kars");

        foreach (string sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMAsk(person1);

        Console.ReadLine();

    }

    static void SelamVer(string isim = "Isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1 = 7, int sayi2 = 6)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam : " + sonuc);
        return sonuc;
    }

    private static void Degiskenler()
    {
        string mesaj = "Merhaba";
        double tutar = 100000; //db den geliyor
        int sayi = 100;
        bool GirisYapmisMi = false;

        string ad = "Engin";
        string soyad = "Demirog";
        int dogumYili = 1985;
        long tcNo = 12345678910;

        Console.WriteLine(tutar * 1.18);

        Console.WriteLine(tutar * 1.18);
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}