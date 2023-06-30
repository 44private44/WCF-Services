using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            Contactus = new HashSet<Contactus>();
            FavouriteMission = new HashSet<FavouriteMission>();
            MissionApplication = new HashSet<MissionApplication>();
            MissionInviteFromUser = new HashSet<MissionInvite>();
            MissionInviteToUser = new HashSet<MissionInvite>();
            MissionRating = new HashSet<MissionRating>();
            Story = new HashSet<Story>();
            Timesheet = new HashSet<Timesheet>();
            UserSkill = new HashSet<UserSkill>();
        }

        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public string WhyIVolunteer { get; set; }
        public string EmployeeId { get; set; }
        public string Department { get; set; }
        public long CityId { get; set; }
        public long CountryId { get; set; }
        public string ProfileText { get; set; }
        public string LinkedInUrl { get; set; }
        public string Title { get; set; }
        public int? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string ConPassword { get; set; }
        public string Manager { get; set; }
        public string Availablity { get; set; }
        public int? Flag { get; set; }
        public int? DeleteStatus { get; set; }
        public string Mobileno { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Contactus> Contactus { get; set; }
        public virtual ICollection<FavouriteMission> FavouriteMission { get; set; }
        public virtual ICollection<MissionApplication> MissionApplication { get; set; }
        public virtual ICollection<MissionInvite> MissionInviteFromUser { get; set; }
        public virtual ICollection<MissionInvite> MissionInviteToUser { get; set; }
        public virtual ICollection<MissionRating> MissionRating { get; set; }
        public virtual ICollection<Story> Story { get; set; }
        public virtual ICollection<Timesheet> Timesheet { get; set; }
        public virtual ICollection<UserSkill> UserSkill { get; set; }
    }
}
