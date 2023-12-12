using EntityLayer.Concrete;

namespace BusinessLayer.ValidationRules;

public class ProductValidator
{
    public bool CheckProductName(Product p)
    {
        if (p.Ad.Length <3 )
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    
    
}