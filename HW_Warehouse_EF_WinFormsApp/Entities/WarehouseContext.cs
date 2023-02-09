using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HW_Warehouse_EF_WinFormsApp.Entities;

public partial class WarehouseContext : DbContext
{
    public WarehouseContext()
    {
    }

    public WarehouseContext(DbContextOptions<WarehouseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<GoodsType> GoodsTypes { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
        .UseSqlServer(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString)
        .UseLazyLoadingProxies();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Deliveri__3214EC075FADAC59");

            entity.HasOne(d => d.Goods).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.GoodsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Deliverie__Goods__2B3F6F97");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Deliverie__Suppl__2C3393D0");
        });

        modelBuilder.Entity<Good>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Goods__3214EC07A3278453");

            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.GoodsType).WithMany(p => p.Goods)
                .HasForeignKey(d => d.GoodsTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Goods__GoodsType__286302EC");
        });

        modelBuilder.Entity<GoodsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GoodsTyp__3214EC07D588955F");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Supplier__3214EC079DF34C90");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
