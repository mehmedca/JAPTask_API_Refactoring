using JAP.Common;
using JAP.Core.Interfaces.IAuth;
using JAP.Core.Interfaces.IRepository;
using JAP.Core.Interfaces.IService;
using JAP.Core.Services;
using JAP.Core.Services.Auth;
using JAP.Database.Context;
using JAP.Integration.Photo;
using JAP.Repository;
using JAP_Task_1_API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Auth settings
            var appSettingsSection = configuration.GetSection("AuthSettings");
            services.Configure<AuthSettings>(appSettingsSection);

            //Cloudinary settings
            var cloudinarySettings = configuration.GetSection("CloudinarySettings");
            services.Configure<CloudinarySettings>(cloudinarySettings);

            //DB configuration
            services.AddDbContext<JAPContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            //Services
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IActorService, ActorService>();

            services.AddScoped<IPhotoService, PhotoService>();


            //Repsitories
            services.AddScoped(typeof(IBaseRepository<,,,,>), typeof(BaseRepository<,,,,>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();


            services.AddScoped<LogUserActivity>();
        }
    }
}
