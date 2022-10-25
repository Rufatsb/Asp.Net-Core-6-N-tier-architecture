using Emobile_Task.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.DAL.DTOs.Cities
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }
        public virtual Country Countries { get; set; } = null!;
        public virtual ICollection<Travel>? Travels { get; set; }
        public bool IsDeleted
        {
            get; set;
        }
    }
}
