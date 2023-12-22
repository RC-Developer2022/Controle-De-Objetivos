using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace Application;

public class AutoMapper : Profile
{ 
    public AutoMapper()
    {
        CreateMap<Objective, ObjectiveDTO>()
            .ReverseMap();
    }
}
