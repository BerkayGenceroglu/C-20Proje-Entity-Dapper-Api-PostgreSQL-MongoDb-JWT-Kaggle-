using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Context;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //Controller, yazılım geliştirmede veri ile kullanıcı arayüzü arasındaki bağlantıyı yöneten bir bileşendir. Genellikle MVC (Model-View-Controller) mimarisinde bulunur ve kullanıcıdan gelen istekleri işler, ilgili model verilerini alır ve uygun görünüme iletir.
    public class WeatherController : ControllerBase
    {
        WeatherContext context = new WeatherContext();
                //IActionResult: Geri döndürme türüdür ve farklı HTTP yanıtlarını döndürmek için kullanılır
                //[HttpGet] metodu değiştirmez, sadece onun nasıl çağrılacağını belirler.
                //Bu metodun sadece HTTP GET isteklerini kabul etmesini sağlar
        [HttpGet]
        public IActionResult WeatherCityList()
       {
            var values = context.Cities.ToList();
            return Ok(values);
       }
        //Bunu bir yol tabelası gibi düşünebilirsin.Yoldaki tabelalar, sürücülerin hangi yöne gitmesi gerektiğini belirtir. İşte[HttpGet] de, ASP.NET'e "Bu metot sadece GET ile çağrılabilir" bilgisini veriyor. 

        [HttpPost]
        public IActionResult CreateWeatherCity(City city)//Bu metod artık sadece HTTP POST istekleriyle çağrılabilir.
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("Şehir Başarılı bir şekilde eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var value = context.Cities.Find(id);
            context.Cities.Remove(value);
            context.SaveChanges();
            return Ok("İşlem Başarılı");
        }

        [HttpPut]
        public IActionResult PutWeatherCity(City city)
        {
            var value = context.Cities.Find(city.CityId);
            value.CityName = city.CityName;
            value.Country = city.Country;
            value.Temp = city.Temp;
            value.Detail = city.Detail;
            context.SaveChanges();
            return Ok("İşlem okey");
        }
        //IActionResult, ASP.NET Core’da bir HTTP yanıtı döndüren metotlar için kullanılan bir dönüş türüdür. Neden kullanıyoruz? Çünkü bir API metodunun farklı türde HTTP yanıtları döndürebilmesini sağlar. Sadece string, bool gibi türler döndürmek yerine, 200 OK, 404 Not Found, 400 Bad Request gibi durumları yönetmemize olanak tanır.
        [HttpGet("GetByIdWeatherCity")]
        public IActionResult GetByIdWeatherCity(int id)
        {
            var value = context.Cities.Find(id);
            return Ok(value);
            //Ok() API'nin başarılı çalıştığını belirtir ve 200 OK yanıtı döndürür.
            //✅ JSON formatında veri döndürmek için kullanılır.
        }

        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var value = context.Cities.Count();
            return Ok(value);
        }

        [HttpGet("MaxTempCity")]
        public IActionResult MaxTempCity()
        {
           var value = context.Cities.OrderByDescending(x => x.Temp).Select(y =>y.CityName).FirstOrDefault();   
            return Ok(value);
        }

        [HttpGet("MinTempCity")]
        public IActionResult MinTempCity()
        {
            var value = context.Cities.OrderBy(x => x.Temp).Select(y => y.CityName).FirstOrDefault();
            return Ok(value);
        }

    }
}
