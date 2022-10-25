using AutoMapper;
using Emobile_Task.DAL.DTOs.Countries;
using Emobile_Task.DAL.DTOs.Travels;
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
    public class TravelService : ITravelService
    {
        public readonly IUnitOfWork _unit;
        public readonly IMapper _mapper;

        public TravelService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;

        }

     
        public async Task<TravelDto> AddTravelAsync(TravelDto TravelDto)
        {
            await _unit.GetRepository<Travel>().AddAsync(_mapper.Map<Travel>(TravelDto));
            await _unit.SaveAsync();

            return TravelDto;
        }
        public async Task<List<TravelDto>> GetAllTravelsAsync()
        {
            var Travels = await _unit.GetRepository<Travel>().GetAllsync();
            var map = _mapper.Map<List<TravelDto>>(Travels);
            return map;
        }

      
    }
}
