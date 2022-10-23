using Emobile_Task.Core.Entities;
using System;
using System.Collections.Generic;

namespace Emobile_Task.DAL.Entities
{
    public partial class City:EntityBase
    {
        public City()
        {
            Travels = new HashSet<Travel>();
        }

        public string Name { get; set; } = null!;
        public int CountriesId { get; set; }
        public virtual Country Countries { get; set; } = null!;
        public virtual ICollection<Travel>? Travels { get; set; }
    }
}
