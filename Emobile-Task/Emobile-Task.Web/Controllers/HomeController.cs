using Emobile_Task.DAL.DTOs.Cities;
using Emobile_Task.DAL.DTOs.Countries;
using Emobile_Task.DAL.DTOs.Travels;
using Emobile_Task.DAL.Entities;
using Emobile_Task.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Emobile_Task.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly ICityService _cityService;
        private readonly ITravelService _travelService;
        private readonly ILoggerService _loggerservice;




        public HomeController(ICountryService countryService, ICityService cityService, ITravelService travelService, ILoggerService loggerservice)
        {
            _countryService = countryService;
            _cityService = cityService;
            _travelService = travelService;
            _loggerservice = loggerservice;
            
        }

        public async Task<IActionResult> Index()
        {
           
            ViewBag.Countries = await _countryService.GetAllCountryAsync();
            List<TravelDto>  Travels = await _travelService.GetAllTravelsAsync();
         
            return View(Travels);
        }

        public async Task<JsonResult> LoadCity(int Id)
        {
            List<CityDto> city = await _cityService.GetCountryofCitiesAsync(Id);
            return Json(new SelectList(city, "Id", "Name"));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AddTravel(TravelDto travel)
        {
            _travelService.AddTravelAsync(travel);
            _loggerservice.InfoPostedData("Yaradıldı", travel);
            return Json("Səyahət əlavə olundu.");

        }
    }
}