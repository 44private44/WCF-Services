using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class MissionMedia
    {
        public long MissionMediaId { get; set; }
        public long MissionId { get; set; }
        public string MediaName { get; set; }
        public string MediaType { get; set; }
        public string MediaPath { get; set; }
        public string Default { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Mission Mission { get; set; }
    }
}
