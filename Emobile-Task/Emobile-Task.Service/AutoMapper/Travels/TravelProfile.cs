using AutoMapper;
using Emobile_Task.DAL.DTOs.Travels;
using Emobile_Task.DAL.Entities;

namespace Emobile_Task.Service.AutoMapper.Countries
{
    public class TravelProfile : Profile
    {
        public TravelProfile()
        {
            CreateMap<TravelDto, Travel>().ReverseMap();
        }
    }
}
