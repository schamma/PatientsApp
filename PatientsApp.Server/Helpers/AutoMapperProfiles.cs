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
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Screenings, ScreeningsDto>();
            CreateMap<AllergyChecks, AllergyChecksDto>();
            CreateMap<FollowUps, FollowUpsDto>();
            CreateMap<MemberUpdateDto, AppUser>();
        }
    }
}
