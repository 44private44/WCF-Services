using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class City
    {
        public City()
        {
            Mission = new HashSet<Mission>();
        }

        public long CityId { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Mission> Mission { get; set; }
    }
}
