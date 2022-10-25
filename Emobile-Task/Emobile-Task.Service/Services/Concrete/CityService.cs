using AutoMapper;
using Emobile_Task.DAL.DTOs.Cities;
using Emobile_Task.DAL.DTOs.Countries;
using Emobile_Task.DAL.Entities;
using Emobile_Task.DAL.UnitOfWorks;
using Emobile_Task.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.Service.Services.Concrete
{
    public class CityService : ICityService
    {
        public readonly IUnitOfWork _unit;
        public readonly IMapper _mapper;

        public CityService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;

        }

        public async Task<List<CityDto>> GetCountryofCitiesAsync(int Id)
        {
            var cities = await _unit.GetRepository<City>().GetAllsync(t => t.CountriesId == Id);
            var map = _mapper.Map<List<CityDto>>(cities);
            return map;

        }
          
    }
    
}
