using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            Mission = new HashSet<Mission>();
        }

        public long CountryId { get; set; }
        public string Name { get; set; }
        public string Iso { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<Mission> Mission { get; set; }
    }
}
