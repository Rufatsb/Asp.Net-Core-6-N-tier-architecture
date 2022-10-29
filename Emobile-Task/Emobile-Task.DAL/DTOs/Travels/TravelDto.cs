using Emobile_Task.DAL.DTOs.Cities;
using Emobile_Task.DAL.DTOs.Countries;
using FluentValidation;
using System.ComponentModel.DataAnnotations;


namespace Emobile_Task.DAL.DTOs.Travels
{
    public class TravelDto
    {
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int CitiesId { get; set; }

        public int CountriesId { get; set; }
        public virtual CityDto? Cities{ get; set; } = null!;
        public virtual CountryDto? Countries { get; set; } = null!;
        public bool IsDeleted
        {
            get; set;
        }

    }
    public class TravelValidator: AbstractValidator<TravelDto> {
        public TravelValidator()
        {
            RuleFor(x => x.StartDate <= x.EndDate);
            RuleFor(x => x.Price > 0);
            



        }
    }

}
