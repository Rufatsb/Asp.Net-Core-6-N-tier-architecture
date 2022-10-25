using Emobile_Task.DAL.DTOs.Countries;
using Emobile_Task.DAL.DTOs.Travels;
using Emobile_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.Service.Services.Abstractions
{
    public interface ITravelService
    {
        Task<TravelDto> AddTravelAsync(TravelDto travel);
        Task<List<TravelDto>> GetAllTravelsAsync();


    }
}
