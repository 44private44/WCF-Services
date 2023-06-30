using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class MissionInvite
    {
        public long MissionInviteId { get; set; }
        public long MissionId { get; set; }
        public long FromUserId { get; set; }
        public long ToUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual User FromUser { get; set; }
        public virtual Mission Mission { get; set; }
        public virtual User ToUser { get; set; }
    }
}
