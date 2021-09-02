using AutoMapper;
using JAP.Core.Entities.Base;
using JAP.Core.Entities.Identity;
using JAP.Core.Interfaces.IRepository;
using JAP.Database.Context;
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
        where TSearch: new()
    {
        protected readonly JAPContext _context;
        protected readonly IMapper _mapper;

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

        public async virtual Task SoftDeleteAsync(object id)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id);

            if (entity is BaseDeleteEntity deletableEntity)
            {
                deletableEntity.IsDeleted = true;
                deletableEntity.DateDeleted = DateTime.Now;
                
                _context.Set<BaseDeleteEntity>().Attach(deletableEntity);
            }
            else if (entity is AppRole role)
            {
                role.IsDeleted = true;
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

        public async virtual Task<IEnumerable<TModel>> GetPageAsync(TSearch search)
        {
            if (search == null)
            {
                search = new TSearch();
            }

            var result = await _context.Set<TDatabase>().ToListAsync();

            return _mapper.Map<IEnumerable<TModel>>(result);
        }

    }
}

