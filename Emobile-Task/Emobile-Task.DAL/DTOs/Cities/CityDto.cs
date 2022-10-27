using Emobile_Task.DAL.DTOs.Countries;
using Emobile_Task.DAL.DTOs.Travels;


namespace Emobile_Task.DAL.DTOs.Cities
{
    public class CityDto
    {

        public CityDto()
        {
            Travels = new HashSet<TravelDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CountriesId { get; set; }
        public virtual CountryDto Countries { get; set; } = null!;
        public virtual ICollection<TravelDto>? Travels { get; set; }
        public bool IsDeleted
        {
            get; set;
        }

    }
}
