using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperPofiles : Profile
    {
        public AutoMapperPofiles()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom( src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            })
            .ForMember(dest => dest.Age, opt => {
                opt.MapFrom( d => d.DateOfBirth.CalculateAge());
            });
            CreateMap<User, UserForDetailedDto>()
            .ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom( src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            })
            .ForMember(dest => dest.Age, opt => {
                opt.MapFrom(d => d.DateOfBirth.CalculateAge());
            });
            CreateMap<Photo, PhotoForDetailedDto>();
            CreateMap<Photo, PhotoForCreationDto>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<PhotoForDetailedDto, Photo>();
            CreateMap<PhotoForReturnDto, Photo>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<UserForRegisterDto, User>();
            CreateMap<UserForDetailedDto, User>();
            CreateMap<UserForLoginDto, User>();
            CreateMap<User, UserForLoginDto>();
            CreateMap<User, UserForUpdateDto>();
            CreateMap<User, UserForRegisterDto>();
        }
    }
}