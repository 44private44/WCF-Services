using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WCFServicesProject.DataModels
{
    public partial class CIPlatformContext : DbContext
    {
        public CIPlatformContext()
        {
        }

        public CIPlatformContext(DbContextOptions<CIPlatformContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CmsPage> CmsPage { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Contactus> Contactus { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<FavouriteMission> FavouriteMission { get; set; }
        public virtual DbSet<GoalMission> GoalMission { get; set; }
        public virtual DbSet<Mission> Mission { get; set; }
        public virtual DbSet<MissionApplication> MissionApplication { get; set; }
        public virtual DbSet<MissionData> MissionData { get; set; }
        public virtual DbSet<MissionDocument> MissionDocument { get; set; }
        public virtual DbSet<MissionInvite> MissionInvite { get; set; }
        public virtual DbSet<MissionMedia> MissionMedia { get; set; }
        public virtual DbSet<MissionRating> MissionRating { get; set; }
        public virtual DbSet<MissionSkill> MissionSkill { get; set; }
        public virtual DbSet<MissionTheme> MissionTheme { get; set; }
        public virtual DbSet<PasswordReset> PasswordReset { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<Story> Story { get; set; }
        public virtual DbSet<StoryInvite> StoryInvite { get; set; }
        public virtual DbSet<StoryMedia> StoryMedia { get; set; }
        public virtual DbSet<Timesheet> Timesheet { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserSkill> UserSkill { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PCA172\\SQL2017;Database=CIPlatform;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=sa;Password=Tatva@123;Integrated Security=False;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("banner");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder)
                    .HasColumnName("sort_order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_country_city");
            });

            modelBuilder.Entity<CmsPage>(entity =>
            {
                entity.ToTable("cms_page");

                entity.Property(e => e.CmsPageId).HasColumnName("cms_page_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comment");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasColumnName("approval_status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.Comment1)
                    .HasColumnName("Comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_comment");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_comment");
            });

            modelBuilder.Entity<Contactus>(entity =>
            {
                entity.ToTable("contactus");

                entity.Property(e => e.ContactusId).HasColumnName("contactus_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("text");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Contactus)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_contactus");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iso)
                    .HasColumnName("ISO")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FavouriteMission>(entity =>
            {
                entity.ToTable("favourite_mission");

                entity.Property(e => e.FavouriteMissionId).HasColumnName("favourite_mission_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.FavouriteMission)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_favmis");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FavouriteMission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_favmis");
            });

            modelBuilder.Entity<GoalMission>(entity =>
            {
                entity.ToTable("goal_mission");

                entity.Property(e => e.GoalMissionId).HasColumnName("goal_mission_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.GoalObjectiveText)
                    .HasColumnName("goal_objective_text")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GoalValue).HasColumnName("goal_value");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.GoalMission)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_goamis");
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.ToTable("mission");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.Availability)
                    .IsRequired()
                    .HasColumnName("availability")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline")
                    .HasColumnType("date");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MissionType)
                    .IsRequired()
                    .HasColumnName("mission_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationDetail)
                    .HasColumnName("organization_detail")
                    .HasColumnType("text");

                entity.Property(e => e.OrganizationName)
                    .HasColumnName("organization_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SeatLeft)
                    .HasColumnName("seat_left")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("short_description")
                    .HasColumnType("text");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ThemeId).HasColumnName("theme_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Mission)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_city_mission");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Mission)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_country_mission");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.Mission)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_theme_mission");
            });

            modelBuilder.Entity<MissionApplication>(entity =>
            {
                entity.ToTable("mission_application");

                entity.Property(e => e.MissionApplicationId).HasColumnName("mission_application_id");

                entity.Property(e => e.AppliedAt)
                    .HasColumnName("applied_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasColumnName("approval_status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PENDING')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.MissionApplication)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_misapp");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MissionApplication)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_misapp");
            });

            modelBuilder.Entity<MissionData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("missionData");

                entity.Property(e => e.Availability)
                    .IsRequired()
                    .HasColumnName("availability")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deadline)
                    .HasColumnName("deadline")
                    .HasColumnType("date");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MissionType)
                    .IsRequired()
                    .HasColumnName("mission_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationDetail)
                    .HasColumnName("organization_detail")
                    .HasColumnType("text");

                entity.Property(e => e.OrganizationName)
                    .HasColumnName("organization_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SeatLeft)
                    .HasColumnName("seat_left")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("short_description")
                    .HasColumnType("text");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ThemeId).HasColumnName("theme_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MissionDocument>(entity =>
            {
                entity.ToTable("mission_document");

                entity.Property(e => e.MissionDocumentId).HasColumnName("mission_document_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasColumnName("document_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath)
                    .HasColumnName("document_path")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasColumnName("document_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.MissionDocument)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_misdoc");
            });

            modelBuilder.Entity<MissionInvite>(entity =>
            {
                entity.ToTable("mission_invite");

                entity.Property(e => e.MissionInviteId).HasColumnName("mission_invite_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.ToUserId).HasColumnName("to_user_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.MissionInviteFromUser)
                    .HasForeignKey(d => d.FromUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fromuser_misinv");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.MissionInvite)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_misinv");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.MissionInviteToUser)
                    .HasForeignKey(d => d.ToUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_touser_misinv");
            });

            modelBuilder.Entity<MissionMedia>(entity =>
            {
                entity.ToTable("mission_media");

                entity.Property(e => e.MissionMediaId).HasColumnName("mission_media_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Default)
                    .IsRequired()
                    .HasColumnName("default")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.MediaName)
                    .HasColumnName("media_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MediaPath)
                    .HasColumnName("media_path")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MediaType)
                    .HasColumnName("media_type")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.MissionMedia)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_mismed");
            });

            modelBuilder.Entity<MissionRating>(entity =>
            {
                entity.ToTable("mission_rating");

                entity.Property(e => e.MissionRatingId).HasColumnName("mission_rating_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.MissionRating)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_misrat");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MissionRating)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_misrat");
            });

            modelBuilder.Entity<MissionSkill>(entity =>
            {
                entity.ToTable("mission_skill");

                entity.Property(e => e.MissionSkillId).HasColumnName("mission_skill_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.MissionSkill)
                    .HasForeignKey(d => d.MissionId)
                    .HasConstraintName("FK_mission_misski");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.MissionSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_skill_misski");
            });

            modelBuilder.Entity<MissionTheme>(entity =>
            {
                entity.ToTable("mission_theme");

                entity.Property(e => e.MissionThemeId).HasColumnName("mission_theme_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.ToTable("password_reset");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(191)
                    .IsUnicode(false);

                entity.Property(e => e.Linkactivate)
                    .HasColumnName("linkactivate")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(191)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("skill");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SkillName)
                    .HasColumnName("skill_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Story>(entity =>
            {
                entity.ToTable("story");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.PublishedAt)
                    .HasColumnName("published_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DRAFT')");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Views).HasColumnName("views");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.Story)
                    .HasForeignKey(d => d.MissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mission_story");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Story)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_story");
            });

            modelBuilder.Entity<StoryInvite>(entity =>
            {
                entity.ToTable("story_invite");

                entity.Property(e => e.StoryInviteId).HasColumnName("story_invite_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.ToUserId).HasColumnName("to_user_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<StoryMedia>(entity =>
            {
                entity.ToTable("story_media");

                entity.Property(e => e.StoryMediaId).HasColumnName("story_media_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("text");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoUrl)
                    .HasColumnName("video_url")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Story)
                    .WithMany(p => p.StoryMedia)
                    .HasForeignKey(d => d.StoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_story_stomed");
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.ToTable("timesheet");

                entity.Property(e => e.TimesheetId).HasColumnName("timesheet_id");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateVolunteered)
                    .HasColumnName("date_volunteered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PENDING')");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.Timesheet)
                    .HasForeignKey(d => d.MissionId)
                    .HasConstraintName("FK_mission_timesheet");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Timesheet)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_user_timesheet");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Availablity)
                    .HasColumnName("availablity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.ConPassword)
                    .HasColumnName("con_password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteStatus)
                    .HasColumnName("delete_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employee_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInUrl)
                    .HasColumnName("linked_in_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Manager)
                    .HasColumnName("manager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileno)
                    .HasColumnName("mobileno")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");

                entity.Property(e => e.ProfileText)
                    .HasColumnName("profile_text")
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.WhyIVolunteer)
                    .HasColumnName("why_i_volunteer")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.ToTable("user_skill");

                entity.Property(e => e.UserSkillId).HasColumnName("user_skill_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.UserSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_skill_userskill");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkill)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_userskill");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
