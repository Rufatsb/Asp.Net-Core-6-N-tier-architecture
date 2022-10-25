using Emobile_Task.DAL.DTOs.Cities;
using Emobile_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.Service.Services.Abstractions
{
    public interface ICityService
    {
        Task<List<CityDto>> GetCountryofCitiesAsync(int id);
    }
}
