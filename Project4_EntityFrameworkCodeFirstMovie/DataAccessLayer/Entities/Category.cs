using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkCodeFirstMovie.DataAccessLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        //Eğer bire-çok ilişkiyi sadece bellek içinde yönetmek istiyorsan, yani veritabanı kullanmadan sadece nesneler arası ilişki kurmak istiyorsan, List<T> doğrudan kullanılabilir.

        public List<Movie> Movies { get; set; }
    }
}
