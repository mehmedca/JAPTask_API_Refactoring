using AutoMapper;
using JAP.Common;
using JAP.Core.Entities.Base;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces.IRepository;
using JAP.Database.Context;
using JAP.Repository.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class BaseRepository<TModel, TSearch, TInsert, TUpdate, TDatabase> : IBaseRepository<TModel, TSearch, TInsert,
        TUpdate, TDatabase>
        where TDatabase : class, new()
        where TSearch : BaseSearch, new()
    {
        protected readonly JAPContext _context;
        protected readonly IMapper _mapper;

        public virtual int DefaultPageSize { get; set; } = 10;

        public BaseRepository(JAPContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public async virtual Task<TModel> AddAsync(TInsert entity)
        {
            var insert = _mapper.Map<TDatabase>(entity);
            await _context.Set<TDatabase>().AddAsync(insert);

            await SaveChangesAsync();

            return _mapper.Map<TModel>(insert);
        }

        public async virtual Task SoftDeleteAsync(object id, string userId)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id);

            if (entity is BaseDeleteEntity deletableEntity)
            {
                deletableEntity.IsDeleted = true;
                deletableEntity.DeletedById = userId;
                deletableEntity.DateDeleted = DateTime.Now;

                _context.Set<BaseDeleteEntity>().Attach(deletableEntity);
            }
            else if (entity is AppRole role)
            {
                role.IsDeleted = true;
                role.DeletedById = userId;
                role.DateDeleted = DateTime.Now;

                _context.Set<AppRole>().Attach(role);
            }
            else
                return;

            _context.Entry(entity).State = EntityState.Modified;

            await SaveChangesAsync();
        }

        public virtual async Task<TModel> GetByIdAsync(object id)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id);
            return _mapper.Map<TModel>(entity);
        }

        public virtual async Task UpdateAsync(object id, TUpdate entity)
        {
            var dbEntity = await _context.Set<TDatabase>().FindAsync(id);
            _mapper.Map(entity, dbEntity);

            _context.Set<TDatabase>().Attach(dbEntity);
            _context.Entry(dbEntity).State = EntityState.Modified;

            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async virtual Task<PagedResult<TModel>> GetPageAsync(TSearch search)
        {
            if (search == null)
            {
                search = new TSearch();
            }

            PagedResult<TModel> result = new PagedResult<TModel>();

            var query = await GetAsync(search);

            result.Count = await GetCountAsync(query);

            AddPaging(search, ref query);
            var res = await query.ToListAsync();

            result.Results = _mapper.Map<IReadOnlyList<TModel>>(res);

            return result;
        }

        protected virtual async Task<IQueryable<TDatabase>> GetAsync(TSearch search)
        {
            var query = _context.Set<TDatabase>().AsQueryable();
            AddInclude(search, ref query);
            query = await AddFilterAsync(search, query);
            AddOrder(search, ref query);
            return await Task.FromResult(query);
        }

        protected virtual void AddInclude(TSearch search, ref IQueryable<TDatabase> query)
        {
            var includes = search.Includes.ToArray();
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }

        protected virtual void AddPaging(TSearch search, ref IQueryable<TDatabase> query)
        {
            if (!search.RetrieveAll.GetValueOrDefault(false) == true)
            {
                if (search.Page < 1)
                    search.Page = 1;

                query = query.Skip((search.Page.GetValueOrDefault(1) - 1)
                    * search.PageSize.GetValueOrDefault(DefaultPageSize))
                    .Take(search.PageSize.GetValueOrDefault(DefaultPageSize));
            }
        }

        protected virtual async Task<long> GetCountAsync(IQueryable<TDatabase> query)
        {
            return await query.LongCountAsync();
        }

        protected virtual async Task<IQueryable<TDatabase>> AddFilterAsync(TSearch search, IQueryable<TDatabase> query)
        {
            AddFilterFromSearchObject(search, ref query);
            return await Task.FromResult(query);
        }

        protected virtual void AddFilterFromSearchObject(TSearch search, ref IQueryable<TDatabase> query)
        {

        }

        protected virtual void AddOrder(TSearch search, ref IQueryable<TDatabase> query)
        {
            if (!string.IsNullOrWhiteSpace(search.SortBy))
            {
                query = query.OrderBy(search.SortBy);
            }
        }
    }
}

