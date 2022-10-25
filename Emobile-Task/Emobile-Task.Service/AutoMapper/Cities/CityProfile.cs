using AutoMapper;
using Emobile_Task.DAL.DTOs.Cities;
using Emobile_Task.DAL.Entities;


namespace Emobile_Task.Service.AutoMapper.Cities
{
    public class CityProfile:Profile
    {
        public CityProfile()
        {
            CreateMap<CityDto, City>().ReverseMap();
        }
    }
}
