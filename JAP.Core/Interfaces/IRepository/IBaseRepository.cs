using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Interfaces.IRepository
{
    public interface IBaseRepository<TModel, TSearch, TInsert, TUpdate, TDatabase>
        where TDatabase : class
    {
        Task<TModel> GetByIdAsync(object id);
        Task<IEnumerable<TModel>> GetPageAsync(TSearch search);
        Task<TModel> AddAsync(TInsert entity);
        Task UpdateAsync(object id, TUpdate entity);
        Task SoftDeleteAsync(object id, string userId = "");
        Task SaveChangesAsync();
    }
}
