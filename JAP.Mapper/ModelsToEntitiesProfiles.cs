using AutoMapper;
using JAP.Core.Entities;
using JAP.Core.Entities.Identity;
using JAP.Core.Models;
using JAP.Core.Models.AuthModels;
using JAP.Core.Models.InsertRequest;
using JAP.Core.Models.UpdateRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Mapper
{
    public class ModelsToEntitiesProfiles : Profile
    {
        public ModelsToEntitiesProfiles()
        {
            //USER
            CreateMap<AppUser, AppUserModel>()
                .ForMember(x => x.FullName, y => y.MapFrom(z => z.FirstName + " " + z.LastName))
                .ForMember(x => x.PhotoUrl, y => y.MapFrom(z => z.UserPhoto.Url))
                .ReverseMap().PreserveReferences();
            CreateMap<AppUserUpdateRequest, AppUser>();

            CreateMap<RegisterModel, AppUser>();

            //ROLE
            CreateMap<AppRole, AppRoleModel>().ReverseMap().PreserveReferences();
            CreateMap<AppRoleInsertRequest, AppRole>();
            CreateMap<AppRoleUpdateRequest, AppRole>();

            //USER_ROLE
            CreateMap<AppUserRole, AppUserRoleModel>().ReverseMap().PreserveReferences();

            //ACTOR
            CreateMap<Actor, ActorModel>()
               .ForMember(x => x.FullName, y => y.MapFrom(z => z.FirstName + " " + z.LastName))
               .ForMember(x => x.PhotoUrl, y => y.MapFrom(z => z.ProfileImg.Url))
               .ReverseMap().PreserveReferences();
            CreateMap<ActorUpdateRequest, Actor>();
            CreateMap<ActorInsertRequest, Actor>();

            //MOVIE
            CreateMap<Movie, MovieModel>()
               .ForMember(x => x.PhotoUrl, y => y.MapFrom(z => z.CoverImage.Url))
               .ReverseMap().PreserveReferences();
            CreateMap<MovieUpdateRequest, Movie>();
            CreateMap<MovieInsertRequest, Movie>();

            //PHOTO
            CreateMap<Photo, PhotoModel>().ReverseMap().PreserveReferences();

            //RATING
            CreateMap<Rating, RatingModel>()
               .ForMember(x => x.RatedByUserUsername, y => y.MapFrom(z => z.RatedByUser.UserName))
               .ReverseMap().PreserveReferences();
            CreateMap<RatingInsertRequest, Rating>();
        }
    }
}
