using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Models;
using JAP.Core.Models.InsertRequest;
using JAP.Database.Context;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Repository
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly IPhotoService _photoService;
        private readonly IMapper _mapper;
        private readonly JAPContext _context;

        public PhotoRepository(JAPContext dbContext, IMapper mapper, IPhotoService photoService)
        {
            _photoService = photoService;
            _mapper = mapper;
            _context = dbContext;
        }


        public async Task<PhotoModel> AddPhotoAsync(IFormFile file)
        {
            var result = await _photoService.AddPhotoAsync(file);

            if (result.Error != null) return null;

            var photo = new Photo
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId
            };

            await _context.AddAsync(photo);
            await SaveChangesAsync();

            return _mapper.Map<PhotoModel>(photo);
        }

        public async Task SaveChangesAsync()
        {
            if(_context.ChangeTracker.HasChanges())
                await _context.SaveChangesAsync();
        }
    }
}
