using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.ContextDB;

public class Context:DbContext
{
    
    //ORM KOMUTLARI
    /*
     * ADD , Remove/Delete , Update/SaveChanges(),
     *
     * 
     */
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=KatmanliDB;Uid=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;MultiSubnetFailover=True");
    }
    
    public DbSet<Product> Products { get; set; }
    
    
    
    
    
    
    
}