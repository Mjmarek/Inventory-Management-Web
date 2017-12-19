namespace Inventory.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModels : DbContext
    {
        public DataModels()
            : base("name=DataModels")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<IdentityRole> IdentityRole { get; set; }
        public virtual DbSet<IdentityUserClaim> IdentityUserClaim { get; set; }
        public virtual DbSet<IdentityUserLogin> IdentityUserLogin { get; set; }
        public virtual DbSet<IdentityUserRole> IdentityUserRole { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.IdentityUserClaim)
                .WithOptional(e => e.ApplicationUser)
                .HasForeignKey(e => e.ApplicationUser_Id);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.IdentityUserLogin)
                .WithOptional(e => e.ApplicationUser)
                .HasForeignKey(e => e.ApplicationUser_Id);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.IdentityUserRole)
                .WithOptional(e => e.ApplicationUser)
                .HasForeignKey(e => e.ApplicationUser_Id);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<IdentityRole>()
                .HasMany(e => e.IdentityUserRole)
                .WithOptional(e => e.IdentityRole)
                .HasForeignKey(e => e.IdentityRole_Id);
        }
    }
}
