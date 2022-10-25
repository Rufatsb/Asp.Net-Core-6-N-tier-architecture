using Emobile_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.DAL.DTOs.Travels
{
    public class TravelDto
    {
        public int Id { get; set; }
        [Required]
        [Range(1, 1000000000000)]
        public int Price { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int CitiesId { get; set; }
        public int CountriesId { get; set; }
        public bool IsDeleted
        {
            get; set;
        }

        }
    }
