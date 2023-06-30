using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class Contactus
    {
        public long ContactusId { get; set; }
        public long UserId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User User { get; set; }
    }
}
