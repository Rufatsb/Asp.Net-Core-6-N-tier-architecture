using AutoMapper;
using Emobile_Task.DAL.DTOs.Countries;
using Emobile_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.Service.AutoMapper.Countries
{
    public class CountryProfile:Profile
    {
        public CountryProfile()
        {
            CreateMap<CountryDto, Country>().ReverseMap();
        }
    }
}
