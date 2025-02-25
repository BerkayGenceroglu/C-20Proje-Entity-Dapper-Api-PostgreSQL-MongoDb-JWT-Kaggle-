using Project4_EntityFrameworkCodeFirstMovie.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkCodeFirstMovie.DataAccessLayer.Context
{
    //DbContextten miras almak, sınıfımıza Entity Framework Core’un veritabanı yönetim yeteneklerini kazandırır.Veritabanı Tabloları ile Çalışmak gibi// veritabanındaki tabloları (entities) temsil eden DbSet özelliklerini içerir ve veritabanı işlemlerini (ekleme, silme, güncelleme, sorgulama vb.) yönetmek için kullanılır.
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    
        public DbSet<Category> Categories { get; set; }
    }
}
