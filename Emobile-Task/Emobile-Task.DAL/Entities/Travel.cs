using Emobile_Task.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Emobile_Task.DAL.Entities
{
    public partial class Travel : EntityBase
    {
        [Required]
        [Range(1,1000000000000)]
        public int Price { get; set; } 
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int CitiesId { get; set; }
        public virtual City? City { get; set; } = null!;
        public int CountriesId { get; set; }
        public virtual Country? Countries { get; set; } = null!;
    }
}
