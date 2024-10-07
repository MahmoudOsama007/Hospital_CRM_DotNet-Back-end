using AutoMapper;
using Test1_Blue_Api.Models;
using Test1_Blue_Api.Models.Dtos;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Company, CompanyDto>().ReverseMap(); // Ensure this line exists
        CreateMap<Customer, CustomerDto>().ReverseMap();
        CreateMap<City, CityDto>().ReverseMap();
        CreateMap<Area, AreaDto>().ReverseMap();
        CreateMap<CallType, CallTypeDto>().ReverseMap();
        CreateMap<CallAbout, CallAboutDto>().ReverseMap();
        CreateMap<CallService, CallServiceDto>().ReverseMap();


        CreateMap<Hospital, HospitalDto>()
             //.ForMember(dest => dest.MajorSpecialists, opt => opt.MapFrom(src => src.MajorSpecialists))
            .ReverseMap();

        CreateMap<MajorSpecialist, MajorSpecialistDto>()
            //.ForMember(dest => dest.MinorSpecialists, opt => opt.MapFrom(src => src.MinorSpecialists))
            .ReverseMap();

        CreateMap<MinorSpecialist, MinorSpecialistDto>()
            //.ForMember(dest => dest.VerySpecificSpecialists, opt => opt.MapFrom(src => src.VerySpecificSpecialists))
            .ReverseMap();

        CreateMap<VerySpecificSpecialist, VerySpecificSpecialistDto>()
            //.ForMember(dest => dest.Doctors, opt => opt.MapFrom(src => src.Doctors))
            .ReverseMap();

        CreateMap<Doctor, DoctorDto>().ReverseMap();
        CreateMap<Ticket, TicketDto>().ReverseMap();


    }
}
