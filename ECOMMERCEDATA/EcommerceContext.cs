
using EcommerceDAContracts;
using EcommerceDAContracts.Entities;
using Microsoft.EntityFrameworkCore;



namespace EcommerceDA
{
    public class EcommerceContext:DbContext , IEcommerceContext
    {


        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }
       public DbSet<ProductsModel> Products { get; set; }
       



        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductsModel>().ToTable("Products");
        }
    }
}
