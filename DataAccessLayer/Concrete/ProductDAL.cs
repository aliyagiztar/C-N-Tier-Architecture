using DataAccessLayer.ContextDB;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete;

public class ProductDAL
{
    private Context c = new Context();

    public void ProductAdd(Product p)
    {
        
        c.Products.Add(p);
        c.SaveChanges();
    }

    public void ProductDelete()
    {
        
    }

    public void ProductUpdate()
    {
        
    }

    public void GetAllProduct()
    {
        
    }
    
    
    
    
    
}