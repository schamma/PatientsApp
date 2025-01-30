using AutoMapper;
using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;
using PatientsApp.Server.Extensions;

namespace PatientsApp.Server.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                //.ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Reccomendations.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            //CreateMap<Reccomendations, ReccomendationsDto>();
            CreateMap<Screenings, ScreeningsDto>();
            CreateMap<AllergyChecks, AllergyCheckDto>();
            CreateMap<FollowUps, FollowUpsDto>();
            CreateMap<MemberUpdateDto, AppUser>();
            //CreateMap<RegisterDto, AppUser>();

            //CreateMap<Message, MessageDto>()
            //    .ForMember(dest => dest.SenderPhotoUrl, opt => opt.MapFrom(src =>
            //        src.Sender.Photos.FirstOrDefault(x => x.IsMain).Url))
            //    .ForMember(dest => dest.RecipientPhotoUrl, opt => opt.MapFrom(src =>
            //        src.Recipient.Photos.FirstOrDefault(x => x.IsMain).Url));

            //CreateMap<MessageDto, Message>();
        }
    }
}
