using Emobile_Task.DAL.DTOs.Countries;


namespace Emobile_Task.Service.Services.Abstractions
{
    public interface ICountryService
    {
        Task<List<CountryDto>> GetAllCountryAsync();

    }
}
