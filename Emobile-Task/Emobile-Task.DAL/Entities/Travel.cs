using Emobile_Task.Core.Entities;
using System;
using System.Collections.Generic;

namespace Emobile_Task.DAL.Entities
{
    public partial class Travel:EntityBase
    {
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CitiesId { get; set; }
        public virtual City Cities { get; set; } = null!;

    }
}
