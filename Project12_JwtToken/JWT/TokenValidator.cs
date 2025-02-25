using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project12_JwtToken.JWT
{
    public class TokenValidator
    {
         //Eğer token geçerliyse kullanıcı bilgilerini içeren nesneyi döndürür.Geçerli değilse null döndürür.
        public ClaimsPrincipal validateJwtToken(string token)
        {
            /*✅ new JwtSecurityTokenHandler() → JWT yönetmek için bir nesne oluşturur.
              ✅ .WriteToken(token) → JWT nesnesini string haline getirir.
              ✅ Bu işlem olmazsa, JWT istemciye gönderilemez!

              🚀 Sonuç:
              Eğer WriteToken() kullanmazsan, JWT’yi kullanamazsın.
              Bu metot, JWT’yi okunabilir bir string formatına çevirir ve istemciye gönderir.*/
            var tokenHandler = new JwtSecurityTokenHandler();
            //JwtSecurityTokenHandler, JWT token’larını okuma, doğrulama ve oluşturma işlemlerini yapar.
            //Bu nesneyi kullanarak token’ı doğrulayıp geçerli olup olmadığını kontrol edeceğiz.
            var key = Encoding.UTF8.GetBytes("BerkayGenceroğluComputerEngineer/1234");

            try
            {
                /*Bu kod, ValidateToken() metodunu çağırarak token’ı doğrular.
                Eğer token geçerliyse, ClaimsPrincipal nesnesi döndürülür.
                Eğer token geçersizse, bir hata fırlatılır ve null döndürülür.*/
                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    //Burada true diyerek "Bu kontrolleri yap!" demiş oluyoruz.
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = "localhost",
                    ValidateAudience = true,
                    ValidAudience = "localhost",
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);
                //Artık validatedToken, JWT'nin doğrulanmış versiyonunu içerir.
                return principal;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
