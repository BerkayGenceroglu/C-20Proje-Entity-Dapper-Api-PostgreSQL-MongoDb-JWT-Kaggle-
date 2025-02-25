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
    public class TokenGenarator
    {
        public string GenerateToken(string username , string email,string name,string surname)
        {
            /*SymmetricSecurityKey: JWT'nin güvenliğini sağlamak için kullanılan gizli anahtardır.SigningCredentials, oluşturduğumuz JWT token'ını imzalamak için kullanılan bir yapıdır.
            Bu imza, token’ın kim tarafından oluşturulduğunu doğrulamak ve token’ın değiştirilmediğinden emin olmak için kullanılır.
            Encoding.UTF8.GetBytes(...): Güvenlik anahtarını byte dizisine çeviriyoruz çünkü JWT’nin şifreleme algoritması string yerine byte formatında anahtar kullanır
            */
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BerkayGenceroğluComputerEngineer/1234"));
            //SigningCredentials: JWT’yi kim imzaladı? ve hangi algoritma ile imzalandı? sorularının cevabını tutar.
            //        securityKey: Bir önceki adımda oluşturduğumuz gizli anahtardır.
            //SecurityAlgorithms.HmacSha256: JWT’nin imzalanması için kullanılan şifreleme algoritmasıdır.


            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            /*
                Claims, JWT içerisine eklenen ve kullanıcının kim olduğunu belirten bilgileri içerir.
                JWT’yi okuyan sistem bu bilgiler sayesinde "Bu token kime ait?" sorusuna yanıt verebilir.

                JwtRegisteredClaimNames.Sub ("test1234"):
                "Sub" (Subject) => Token’ın sahibini belirtir. (Burada kullanıcı kimliği "test1234")
                JwtRegisteredClaimNames.Email ("berko@gmail.com"):
                Kullanıcının e-posta adresini belirtir.
                JwtRegisteredClaimNames.Jti (Guid.NewGuid().ToString()):
                Jti (JWT ID) => Token’ın benzersiz bir kimliği olmasını sağlar.
                ✅ Günlük Hayattan Örnek:
                Bu, bir uçak bileti gibi düşünülebilir.
                Bir uçak bileti üzerinde:

                Yolcunun adı (Sub) yazılıdır.
                E-posta adresi (Email) kayıtlıdır.
                Bilet numarası (Jti) benzersizdir.
                Her yolcunun bileti farklı olduğu için bilet numarası da benzersizdir.
             */

            //JwtRegisteredClaimNames, JWT içinde yaygın olarak kullanılan önceden tanımlı claim adlarını içerir ve standartlara uygun token oluşturmanı sağlar.
            var claimsExample = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,username),
                new Claim(JwtRegisteredClaimNames.Email,email),
                new Claim(JwtRegisteredClaimNames.GivenName,name),
                new Claim(JwtRegisteredClaimNames.FamilyName,surname),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims: claimsExample,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public string GenerateToken2(string username)
        {
            /*SymmetricSecurityKey: JWT'nin güvenliğini sağlamak için kullanılan gizli anahtardır.SigningCredentials, oluşturduğumuz JWT token'ını imzalamak için kullanılan bir yapıdır.
            Bu imza, token’ın kim tarafından oluşturulduğunu doğrulamak ve token’ın değiştirilmediğinden emin olmak için kullanılır.
            Encoding.UTF8.GetBytes(...): Güvenlik anahtarını byte dizisine çeviriyoruz çünkü JWT’nin şifreleme algoritması string yerine byte formatında anahtar kullanır
            */
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BerkayGenceroğluComputerEngineer/1234"));
            //SigningCredentials: JWT’yi kim imzaladı? ve hangi algoritma ile imzalandı? sorularının cevabını tutar.
            //        securityKey: Bir önceki adımda oluşturduğumuz gizli anahtardır.
            //SecurityAlgorithms.HmacSha256: JWT’nin imzalanması için kullanılan şifreleme algoritmasıdır.


            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            /*
                Claims, JWT içerisine eklenen ve kullanıcının kim olduğunu belirten bilgileri içerir.
                JWT’yi okuyan sistem bu bilgiler sayesinde "Bu token kime ait?" sorusuna yanıt verebilir.

                JwtRegisteredClaimNames.Sub ("test1234"):
                "Sub" (Subject) => Token’ın sahibini belirtir. (Burada kullanıcı kimliği "test1234")
                JwtRegisteredClaimNames.Email ("berko@gmail.com"):
                Kullanıcının e-posta adresini belirtir.
                JwtRegisteredClaimNames.Jti (Guid.NewGuid().ToString()):
                Jti (JWT ID) => Token’ın benzersiz bir kimliği olmasını sağlar.
                ✅ Günlük Hayattan Örnek:
                Bu, bir uçak bileti gibi düşünülebilir.
                Bir uçak bileti üzerinde:

                Yolcunun adı (Sub) yazılıdır.
                E-posta adresi (Email) kayıtlıdır.
                Bilet numarası (Jti) benzersizdir.
                Her yolcunun bileti farklı olduğu için bilet numarası da benzersizdir.
             */

            //JwtRegisteredClaimNames, JWT içinde yaygın olarak kullanılan önceden tanımlı claim adlarını içerir ve standartlara uygun token oluşturmanı sağlar.
            var claimsExample = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,username),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims: claimsExample,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
