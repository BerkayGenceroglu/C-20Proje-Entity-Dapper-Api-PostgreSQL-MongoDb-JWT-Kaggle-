//Consume API, bir uygulamanın başka bir uygulamanın sunduğu API’yi kullanması anlamına gelir.
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Unicode;
using static System.Net.WebRequestMethods;

Console.WriteLine("Api Consume İşlemine Hoşgeldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1-Sehir Listesini Getirin");
Console.WriteLine("2-Sehir ve Hava Durumu Listesini Getirin");
Console.WriteLine("3-Yeni Şehir Ekleme");
Console.WriteLine("4-Sehir Silme İşlemi");
Console.WriteLine("5-Sehir Güncelleme İşlemi");
Console.WriteLine("6-Id'ye göre şehir getirme");
Console.WriteLine();

string number;
Console.Write("Tercihiniz: ");
number = Console.ReadLine();
Console.WriteLine();


    if (number == "1")
    {
        string url = "https://localhost:7182/api/Weather";
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            //HttpResponseMessage, API'den gelen cevabı saklar.
            //İçinde durum kodu, gelen veri, hata mesajları gibi bilgiler olur.
            //Cevabın başarılı olup olmadığını kontrol etmek için kullanılır.
            string responseBody = await responseMessage.Content.ReadAsStringAsync();
            //HTTP isteğinden dönen JSON içeriğini string olarak okur.
            JArray jarray = JArray.Parse(responseBody);
            foreach (var item in jarray)
            {
                string cityname = item["cityName"].ToString();
                Console.WriteLine($"Şehir: {cityname}");
            }
        }

    }
    if (number == "2")
    {
        string url = "https://localhost:7182/api/Weather";
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            string responseBody = await responseMessage.Content.ReadAsStringAsync();
        //Yani, HTTP’den gelen veriyi JSON olarak işleyebilmek için önce string’e çevirmek zorundayız
            JArray jarray = JArray.Parse(responseBody);
        //Artık JSON dizisi içindeki verilere programatik olarak erişebilirsin!
            foreach (var item in jarray)
            {
                string cityname = item["cityName"].ToString();
                string country = item["country"].ToString();
                string temp = item["temp"].ToString();
                Console.WriteLine(country + "/// " + cityname + "=== " + temp);
            Console.WriteLine("------------------------------------------");
            }
        }
    }
    if (number == "3")
    {
    Console.WriteLine("### Yeni Veri Girişi ###");
    Console.WriteLine();
    string cityName, Country, detail;
    decimal temp;

    Console.Write("Şehir Adı:");
    cityName = Console.ReadLine();

    Console.Write("Ülke Adı:");
    Country = Console.ReadLine();

    Console.Write("Sıcaklık:");
    temp = decimal.Parse(Console.ReadLine());

    Console.Write("Hava Durumu:");
    detail = Console.ReadLine();

    string url = "https://localhost:7182/api/Weather";

    var newData = new
    {
        CityName = cityName,
        Country = Country,
        Temp = temp,
        Detail = detail
    };
    //HttpClient, API’lere istek göndermek için kullanılan bir C# kütüphanesidir.
    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(newData);
            //Çok iyi bir soru! Neden JSON'u string olarak gönderiyoruz? Çünkü HTTP protokolü sadece metin tabanlı veri aktarır.Evet, JSON formatında doğrudan yollayamıyoruz, önce onu bir string yapmamız gerekiyor. Çünkü HTTP istekleri sadece metin (string) tabanlı veri kabul eder.
        StringContent content = new StringContent(json,Encoding.UTF8,"application/json");
        /*
            json → API'ye göndermek istediğimiz JSON formatındaki string.
            Encoding.UTF8 → Türkçe karakterlerin düzgün gönderilmesi için UTF-8 kodlaması kullanılıyor.
            "application/json" → API'ye "Ben JSON formatında veri gönderiyorum" diyoruz.
            Eğer bunu belirtmezsek, API gönderdiğimiz veriyi düzgün anlayamayabilir.
         */
        HttpResponseMessage response = await client.PostAsync(url,content);
            //client.PostAsync(url, content) → API’ye bir POST isteği atıyor.
            //        url → API’nin adresi(örn: "https://localhost:7182/api/Weather").
            //content → Gönderilecek JSON verisini içeren StringContent nesnesi.
            //await kullanıldığı için isteğin tamamlanmasını bekliyoruz.
            //API’nin cevabı HttpResponseMessage response değişkenine atanıyor.
        response.EnsureSuccessStatusCode();
            //API’nin yanıtını kontrol ediyor 
    }


}
    if (number == "4")
    {
    string url = "https://localhost:7182/api/Weather?id=";
    Console.Write("Silmek İstediğiniz Değeri Girin:");
    int id = int.Parse(Console.ReadLine());
    using(HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.DeleteAsync(url + id);
        response.EnsureSuccessStatusCode();
        //EnsureSuccessStatusCode(): Bu metot, HTTP yanıt kodunun başarılı olup olmadığını kontrol eder.
    }

}
    if (number == "5") 
    { 
        string url = "https://localhost:7182/api/Weather";

        Console.WriteLine("### Veri Güncelleme ###");
        Console.WriteLine();
        string cityName, Country, detail;
        decimal temp;
        int id;

        Console.Write("Şehir Id:");
        id = int.Parse(Console.ReadLine());

        Console.Write("Şehir Adı:");
        cityName = Console.ReadLine();

        Console.Write("Ülke Adı:");
        Country = Console.ReadLine();

        Console.Write("Sıcaklık:");
        temp = decimal.Parse(Console.ReadLine());

        Console.Write("Hava Durumu:");
        detail = Console.ReadLine();

        var UpdatedValues = new
        {
                CityId =id,
                CityName = cityName,
                Country = Country,
                Temp = temp,
                Detail = detail
           
        };

        using (HttpClient client = new HttpClient())
        {
            string json = JsonConvert.SerializeObject(UpdatedValues);
            StringContent content = new StringContent(json, Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
        }
     }
if (number == "6")
{
    string url = "https://localhost:7182/api/Weather/GetByIdWeatherCity?id=";
    Console.WriteLine("Lütfen Id değerinizi giriniz");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine();

    using(HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url + id);
        string responseBody = await response.Content.ReadAsStringAsync();
        JObject json = JObject.Parse(responseBody);
        //JObject.Parse(responseBody) ile bu JSON string'i, JObject nesnesine çevriliyor.
        //Evet, string'e çevirmeden direkt olarak JObject oluşturamazsın, çünkü JObject.Parse() sadece string alır. Ancak alternatif bir yol var!
        string cityName = json["cityName"].ToString();
        string detail = json["detail"].ToString();
        string country = json["country"].ToString();
        decimal temp = decimal.Parse(json["temp"].ToString());
        Console.WriteLine("Girmiş Olduğunuz Bilgiler");
        Console.WriteLine();
        Console.Write("ŞEHİR:" + cityName + "//" + "ÜLKE:" + country + "//" + "SICAKLIK:" + temp + "//" + "AÇIKLAMA:" + detail);
    }

}

Console.Read();
//HttpClient ile internetten veri alabilirsin.
//✅ API'lere veri gönderebilirsin.
//✅ GetStringAsync() → Veri almak için
//✅ PostAsync() → Veri göndermek için
//✅ using ile kullanırsan bağlantıyı otomatik kapatır



/*using Newtonsoft.Json.Linq;

// Varsayalım ki responseMessage.Content'ten okunan JSON string bu:
string responseBody = "[{\"ad\": \"Ahmet\", \"yas\": 25}, {\"ad\": \"Mehmet\", \"yas\": 30}]";

// JSON string'ini JArray formatına çeviriyoruz
JArray jarray = JArray.Parse(responseBody);

// JSON içeriğini kontrol edelim
foreach (var item in jarray)
{
    Console.WriteLine($"Ad: {item["ad"]}, Yaş: {item["yas"]}");
}
 Elimizde bir JSON dizisi ([...]) string olarak varsa, bunu JArray.Parse() ile işlenebilir hale getiriyoruz.
✅ Bu sayede JSON içindeki değerlere erişebilir ve kullanabiliriz.
 
 */
/*✅ Gerçek JSON bir veri nesnesidir, doğrudan işlenebilir.
❌ String JSON ise sadece bir metindir, JSON nesnesine çevirmeden işlenemez.
🛠 C# veya başka dillerde JSON formatındaki string’i parse ederek JSON nesnesine dönüştürmek gerekir. */