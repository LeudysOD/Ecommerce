using EcommerceDAContracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EcommerceDAContracts
{
    public interface IEcommerceContext
    {

        
       public DbSet<ProductsModel> Products { get; set; } 

       DbSet<TEntity> Set<TEntity>() where TEntity : class; 
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();

        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);

        
    }
}
