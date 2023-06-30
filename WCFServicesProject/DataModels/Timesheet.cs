using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class Timesheet
    {
        public long TimesheetId { get; set; }
        public long? UserId { get; set; }
        public long? MissionId { get; set; }
        public TimeSpan? Time { get; set; }
        public int? Action { get; set; }
        public DateTime DateVolunteered { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Mission Mission { get; set; }
        public virtual User User { get; set; }
    }
}
