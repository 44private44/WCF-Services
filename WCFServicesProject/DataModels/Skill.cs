using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class Skill
    {
        public Skill()
        {
            MissionSkill = new HashSet<MissionSkill>();
            UserSkill = new HashSet<UserSkill>();
        }

        public long SkillId { get; set; }
        public string SkillName { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? Flag { get; set; }

        public virtual ICollection<MissionSkill> MissionSkill { get; set; }
        public virtual ICollection<UserSkill> UserSkill { get; set; }
    }
}
