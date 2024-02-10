// See https://aka.ms/new-console-template for more information


/*  private static void Degiskenler()
  {

      string mesaj = "Merhaba";
      double tutar = 10000;
      int sayi = 100;
      bool girisYapmisMi = false;

      string ad = "Engin";
      string soyad = "Demirog";
      int dogumYili = 1985;
      long tcNO = 12345678910;

      Console.WriteLine(tutar * 1.18);
      Console.WriteLine(tutar * 1.18);
  }*/

//Degiskenler();
using Business.Concrete;
using Entities.Concrete;

static int Topla(int sayi1=5,int sayi2=5)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam" + sonuc.ToString());
    return sonuc ;
}

static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba" + isim);
}
SelamVer();
Topla();


string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Murat";
ogrenciler[2] = "Kerem";


for(int i=0;i<ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Engin";
person1.LastName = "Drmirog";
person1.DateOfBirth = 2000;
person1.NationalIdentity = 123;
Person person2 = new Person();
person2.FirstName = "Murat";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler = new List<string> { "Ankara", "Istanbul", "Izmir" };
yeniSehirler.Add(item: "Izmir");
foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
PttManager pttManager = new PttManager(new PersonManager ());
pttManager.GiveMask(person1);
public class Vatandas
 {
     public string Ad { get; set; }
     public string Soyad { get; set; }
     public int DogumYili { get; set; }
     public long TcNo { get; set; }
 }


