/* While döngüsünde bir işlemin koşulu sağlandığı takdirde kod bloğunu çalıştırır
 * Do While ise kod bloğunu bir kere gerçekleştirir daha sonrasında koşulun sağlanıp sağlanmadığını kontrol eder.
 * Bu iki döngüye örnek vermek gerekirse; bir internet sitesine giriş yapılması sırasında While döngüsü ilk önce kullanıcı adının doğru girilmesi ardından şifre ekranının gelmesi Do While Döngüsü ise kullanıcı adı ve şifre ekranının aynı anda gelmesi olarak yorumladım*/




// While dögüsü için limit ve sayac değişkenleri tanımlandı

int limit = 0;
int sayac = 0;

// Kullanıcı girdi int veri tipine dönüştürüldü.
Console.WriteLine("Bir Limit Giriniz");
limit = int.Parse(Console.ReadLine());


while (sayac <= limit)//Kullanıcıdan alınan girdi ie sayac arasında koşul oluşturuldu
{
    //Koşu tamamlanana kadar belirtilen veri ekrana yazıldı
    Console.WriteLine("Ben Bir Patikalıyım");
    sayac++;
}

// Do While dögüsü için limit ve sayac değişkenleri tanımlandı
int limit2 = 0;
int sayac2= 0;

// Kullanıcı girdi int veri tipine dönüştürüldü.
Console.WriteLine("Bir Limit Giriniz");
limit2 = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Ben Bir Patikalıyım");//Koşu tamamlanana kadar belirtilen veri ekrana yazıldı
    sayac2++;
}while (sayac2 <= limit2);//Kullanıcıdan alınan girdi ie sayac arasında koşul oluşturuldu