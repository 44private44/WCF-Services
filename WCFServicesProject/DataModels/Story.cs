using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class Story
    {
        public Story()
        {
            StoryMedia = new HashSet<StoryMedia>();
        }

        public long StoryId { get; set; }
        public long UserId { get; set; }
        public long MissionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long? Views { get; set; }
        public int? Flag { get; set; }

        public virtual Mission Mission { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<StoryMedia> StoryMedia { get; set; }
    }
}
