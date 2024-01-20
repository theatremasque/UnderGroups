using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using UnderGroups.Core;

namespace UnderGroups.Infrastructure
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupType> GroupTypes { get; set; }
        public DbSet<UnderGroup> UnderGroups { get; set; }
        public DbSet<LearningGroup> LearningGroups { get; set; }

        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnderGroup>()
                .HasOne(ug => ug.Group)
                .WithMany(g => g.UnderGroups)
                .HasForeignKey(ug => ug.GroupId);

            modelBuilder.Entity<UnderGroup>()
                .HasOne(ug => ug.GroupType)
                .WithMany(gt => gt.UnderGroups)
                .HasForeignKey(ug => ug.GroupTypeId);

            modelBuilder.Entity<UnderGroup>()
                .HasOne(ug => ug.Student)
                .WithMany(s => s.UnderGroups)
                .HasForeignKey(ug => ug.StudentId);

            modelBuilder.Entity<LearningGroup>()
                .HasKey(k => new { k.UnderGroupId, k.StudentId });

            modelBuilder.Entity<LearningGroup>()
               .HasOne(e => e.UnderGroup)
               .WithMany(e => e.LearningGroups)
               .HasForeignKey(e => e.UnderGroupId);

            modelBuilder.Entity<LearningGroup>()
               .HasOne(e => e.Student)
               .WithMany(e => e.LearningGroups)
               .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<StudentGroup>()
               .HasKey(k => new { k.StudentId, k.GroupId });

            modelBuilder.Entity<StudentGroup>()
                .HasOne(e => e.Student)
                .WithMany(e => e.StudentGroups)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<StudentGroup>()
                .HasOne(e => e.Group)
                .WithMany(e => e.StudentGroups)
                .HasForeignKey(e => e.GroupId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
