using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class Mission
    {
        public Mission()
        {
            Comment = new HashSet<Comment>();
            FavouriteMission = new HashSet<FavouriteMission>();
            GoalMission = new HashSet<GoalMission>();
            MissionApplication = new HashSet<MissionApplication>();
            MissionDocument = new HashSet<MissionDocument>();
            MissionInvite = new HashSet<MissionInvite>();
            MissionMedia = new HashSet<MissionMedia>();
            MissionRating = new HashSet<MissionRating>();
            MissionSkill = new HashSet<MissionSkill>();
            Story = new HashSet<Story>();
            Timesheet = new HashSet<Timesheet>();
        }

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

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual MissionTheme Theme { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<FavouriteMission> FavouriteMission { get; set; }
        public virtual ICollection<GoalMission> GoalMission { get; set; }
        public virtual ICollection<MissionApplication> MissionApplication { get; set; }
        public virtual ICollection<MissionDocument> MissionDocument { get; set; }
        public virtual ICollection<MissionInvite> MissionInvite { get; set; }
        public virtual ICollection<MissionMedia> MissionMedia { get; set; }
        public virtual ICollection<MissionRating> MissionRating { get; set; }
        public virtual ICollection<MissionSkill> MissionSkill { get; set; }
        public virtual ICollection<Story> Story { get; set; }
        public virtual ICollection<Timesheet> Timesheet { get; set; }
    }
}
