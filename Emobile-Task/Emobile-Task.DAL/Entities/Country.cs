using Emobile_Task.Core.Entities;
using System;
using System.Collections.Generic;

namespace Emobile_Task.DAL.Entities
{
    public partial class Country:EntityBase
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public string Name { get; set; } = null!;

        public virtual ICollection<City> Cities { get; set; }
    }
}
