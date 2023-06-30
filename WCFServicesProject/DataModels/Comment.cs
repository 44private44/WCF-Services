using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class Comment
    {
        public long CommentId { get; set; }
        public long UserId { get; set; }
        public long MissionId { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Comment1 { get; set; }
        public string Username { get; set; }

        public virtual Mission Mission { get; set; }
        public virtual User User { get; set; }
    }
}
