using AutoMapper;
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
    public class CountryService : ICountryService
    {
        public readonly IUnitOfWork _unit;
        public readonly IMapper _mapper;

        public CountryService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;

        }
        public async Task<List<CountryDto>> GetAllCountryAsync()
        {
            var countries = await _unit.GetRepository<Country>().GetAllsync();
            var map = _mapper.Map<List<CountryDto>>(countries);
            return map;
        }
    }
}
