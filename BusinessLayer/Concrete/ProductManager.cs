using EntityLayer.Concrete;
using DataAccessLayer.Concrete;
namespace BusinessLayer.Concrete;

public class ProductManager
{
    
    private ProductDAL _productDal = new ProductDAL();
    
    
    public void ProductAdd(Product p)
    {
        _productDal.ProductAdd(p);
    }
    
    
}