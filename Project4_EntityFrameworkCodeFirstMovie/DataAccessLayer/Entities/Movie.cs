using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkCodeFirstMovie.DataAccessLayer.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string MovieTitle { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CategoryId { get; set; } //Foreign Key (Yabancı Anahtar). Filmin hangi kategoriye ait olduğunu belirtir.


        public Category category { get; set; } //Navigation Property (Bağlantı Özelliği). Filmin ilişkili olduğu kategori nesnesini içerir.Foreign Key (CategoryId) kullanarak ilgili Category nesnesini getirir.


    }
}

        //Eğer bir navigation property(Category, Author gibi ilişkili tablolar) virtual olarak tanımlanmışsa, Entity Framework bu özelliği proxy(dinamik alt sınıf) oluşturarak sarar.
        //İlişkili veriyi çağırdığında, veritabanına otomatik olarak sorgu atarak ilgili veriyi getirir.
        //Eğer virtual kullanmazsan, ilişkili veriler otomatik yüklenmez, ayrıca Include() ile çağırman gerekir.
        //Eğer bir metod virtual (sanal) olarak işaretlenirse, alt sınıflar bu metodu override (ezebilir).
        //Böylece alt sınıflar, üst sınıfta verilen varsayılan davranışı değiştirebilir.