using Emobile_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.DAL.DTOs.Countries
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<City>? Cities { get; set; }
        public bool IsDeleted
        {
            get; set;
        }
    }
}
