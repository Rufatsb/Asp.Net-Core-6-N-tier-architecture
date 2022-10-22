using System;
using System.Collections.Generic;

namespace Emobile_Task.DAL.DataModels
{
    public partial class Travel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CitiesId { get; set; }

        public virtual City Cities { get; set; } = null!;
    }
}
