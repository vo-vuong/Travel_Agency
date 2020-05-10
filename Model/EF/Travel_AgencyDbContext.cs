namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Travel_AgencyDbContext : DbContext
    {
        public Travel_AgencyDbContext()
            : base("name=Travel_AgencyDbContext")
        {
        }

        public virtual DbSet<ABOUT> ABOUTs { get; set; }
        public virtual DbSet<BAIVIET> BAIVIETs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<BINHLUAN> BINHLUANs { get; set; }
        public virtual DbSet<DANHGIATOUR> DANHGIATOURs { get; set; }
        public virtual DbSet<DANHMUCTOUR> DANHMUCTOURs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<LOAIBAIVIET> LOAIBAIVIETs { get; set; }
        public virtual DbSet<MESSAGE> MESSAGEs { get; set; }
        public virtual DbSet<SLIDE> SLIDEs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<TOUR> TOURs { get; set; }
        public virtual DbSet<TOURKHUYENMAI> TOURKHUYENMAIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANHGIATOUR>()
                .Property(e => e.ma_DanhGia)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.dienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<TOUR>()
                .Property(e => e.gia)
                .HasPrecision(19, 4);
        }
    }
}
