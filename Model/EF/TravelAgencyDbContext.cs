namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TravelAgencyDbContext : DbContext
    {
        public TravelAgencyDbContext()
            : base("name=TravelAgencyDbContext")
        {
        }

        public virtual DbSet<ABOUT> ABOUTs { get; set; }
        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<CATEGORY_TOUR> CATEGORY_TOUR { get; set; }
        public virtual DbSet<COMMENT> COMMENTs { get; set; }
        public virtual DbSet<CONTENT> CONTENTs { get; set; }
        public virtual DbSet<CONTENTCATEGORY> CONTENTCATEGORies { get; set; }
        public virtual DbSet<MESSAGE> MESSAGEs { get; set; }
        public virtual DbSet<SALE> SALEs { get; set; }
        public virtual DbSet<SLIDE> SLIDEs { get; set; }
        public virtual DbSet<TOUR> TOURs { get; set; }
        public virtual DbSet<TOUREVALUATION> TOUREVALUATIONs { get; set; }
        public virtual DbSet<USERGROUP> USERGROUPs { get; set; }
        public virtual DbSet<MENU> MENUs { get; set; }
        public virtual DbSet<TOURSALE> TOURSALEs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TOUR>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<USERGROUP>()
                .HasMany(e => e.ACCOUNTs)
                .WithRequired(e => e.USERGROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TOURSALE>()
                .Property(e => e.SaleRate)
                .HasPrecision(18, 0);
        }
    }
}
