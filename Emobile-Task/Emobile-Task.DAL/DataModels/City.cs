using System;
using System.Collections.Generic;

namespace Emobile_Task.DAL.DataModels
{
    public partial class City
    {
        public City()
        {
            Travels = new HashSet<Travel>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CountriesId { get; set; }

        public virtual Country Countries { get; set; } = null!;
        public virtual ICollection<Travel>? Travels { get; set; }
    }
}
