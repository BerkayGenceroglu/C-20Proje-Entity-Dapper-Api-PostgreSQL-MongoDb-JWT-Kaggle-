using Project5_DapperNortwind.Dtos;
using Project5_DapperNortwind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNortwind.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        //C#'ta Task, asenkron (aynı anda birden fazla işlem yürütme) işlemleri yönetmek için kullanılan bir veri türüdür
        //Task, C#’ta asenkron işlemleri yönetmek için kullanılır ve uzun süren işlemleri daha verimli hale getirir. Özellikle async ve await ile kullanıldığında UI donmalarını ve performans kayıplarını önler.
        //eğer await kullanmazsanız Task beklenmeden çalışır ve sonuç eksik olabilir.
        //✅ Task → Void döndürür
        //✅ Task<T> → Belirli bir tipte değer döndürür
        //✅ Task.WhenAll() → Birden fazla Task’i paralel çalıştırır
        Task<List<ResultCategoryDtos>> GetAllCategoryAsync();

        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);

        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);

        Task DeleteCategoryAsync(int id);

        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);

    }
}
