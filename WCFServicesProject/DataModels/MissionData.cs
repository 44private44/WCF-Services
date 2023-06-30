using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class MissionData
    {
        public long MissionId { get; set; }
        public long ThemeId { get; set; }
        public long CityId { get; set; }
        public long CountryId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MissionType { get; set; }
        public string Status { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDetail { get; set; }
        public string Availability { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string SeatLeft { get; set; }
        public DateTime? Deadline { get; set; }
        public int? Flag { get; set; }
    }
}
