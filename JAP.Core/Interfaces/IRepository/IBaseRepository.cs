using JAP.Common;
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
        Task<PagedResult<TModel>> GetPageAsync(TSearch request);
        Task<TModel> AddAsync(TInsert request);
        Task UpdateAsync(object id, TUpdate request);
        Task SoftDeleteAsync(object id);
        Task SaveChangesAsync();
    }
}
