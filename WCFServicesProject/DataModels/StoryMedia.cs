using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class StoryMedia
    {
        public long StoryMediaId { get; set; }
        public long StoryId { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string VideoUrl { get; set; }

        public virtual Story Story { get; set; }
    }
}
