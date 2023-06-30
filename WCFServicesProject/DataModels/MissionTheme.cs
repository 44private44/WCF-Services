using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class MissionTheme
    {
        public MissionTheme()
        {
            Mission = new HashSet<Mission>();
        }

        public long MissionThemeId { get; set; }
        public string Title { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? Flag { get; set; }

        public virtual ICollection<Mission> Mission { get; set; }
    }
}
