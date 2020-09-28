using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.entities
{
    public class abcContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<orderDetail> orderDetails { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<userRole> userRoles { get; set; }
        public DbSet<role> roles { get; set; }
        public DbSet<supplyDetail> supplyDetails { get; set; }
        public DbSet<supply> supplies { get; set; }
        public DbSet<supplier> suppliers { get; set; }
        public DbSet<productPicture> productPictures { get; set; }
        public DbSet<DiscountCoupon> discountCoupons { get; set; }
        public DbSet<discountCategory> discountCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=abcDb;Integrated Security=True;MultipleActiveResultSets=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreing key
            modelBuilder.Entity<discountCategory>().HasKey(dcc => new { dcc.categoryId, dcc.discountCouponId });
            modelBuilder.Entity<discountCategory>().HasKey(id => new { id.categoryId, id.discountCouponId });
            modelBuilder.Entity<discountCategory>()
                .HasOne(dcc => dcc.category).WithMany(c => c.discountCategories).HasForeignKey(dcc => dcc.categoryId);
            modelBuilder.Entity<discountCategory>().HasOne(dcc => dcc.discountCoupon).WithMany(dc => dc.discountCategories)
                .HasForeignKey(dcc => dcc.discountCouponId);
            modelBuilder.Entity<supplyDetail>().HasOne(sD => sD.product).WithMany(p => p.supplyDetails).HasForeignKey(sD => sD.productId);
            modelBuilder.Entity<Product>().HasOne(p => p.category).WithMany(c => c.Products).HasForeignKey(p => p.categoryId);
            modelBuilder.Entity<productPicture>().HasOne(pp => pp.product).WithMany(p => p.productPictures).HasForeignKey(pp => pp.productId);

            modelBuilder.Entity<userRole>().HasKey(id => new { id.roleId, id.userId });
            modelBuilder.Entity<userRole>().HasOne(ur => ur.user).WithMany(u => u.userRoles).HasForeignKey(ur => ur.userId);
            modelBuilder.Entity<userRole>().HasOne(ur => ur.role).WithMany(r => r.userRoles).HasForeignKey(ur => ur.roleId);
            modelBuilder.Entity<order>().HasOne(o => o.user).WithMany(u => u.orders).HasForeignKey(o => o.userId);
            modelBuilder.Entity<orderDetail>().HasOne(od => od.order).WithMany(o => o.orderDetails).HasForeignKey(od => od.orderId);
            modelBuilder.Entity<orderDetail>().HasOne(od => od.product).WithMany(p => p.orderDetails).HasForeignKey(od => od.productId);
            modelBuilder.Entity<supply>().HasOne(s => s.supplier).WithMany(sr => sr.supplies).HasForeignKey(s => s.supplierId);
            modelBuilder.Entity<supplyDetail>().HasOne(sd => sd.product).WithMany(p => p.supplyDetails).HasForeignKey(sd => sd.productId);
            modelBuilder.Entity<supplyDetail>().HasOne(sd => sd.supply).WithMany(s => s.supplyDetails).HasForeignKey(sd => sd.supplyId);
        }

    }

}
