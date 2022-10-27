using Emobile_Task.DAL.DTOs.Cities;
using Emobile_Task.DAL.DTOs.Travels;

namespace Emobile_Task.DAL.DTOs.Countries
{
    public class CountryDto
    {
        public CountryDto()
        {
            Cities = new HashSet<CityDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<CityDto>? Cities { get; set; }
        public virtual ICollection<TravelDto>? Travels { get; set; }

        public bool IsDeleted
        {
            get; set;
        }

    }
}
