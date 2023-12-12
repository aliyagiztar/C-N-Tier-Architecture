using System.Diagnostics;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Katmanli_Mimari.Models;

namespace Katmanli_Mimari.Controllers;

public class HomeController : Controller
{
    ProductManager pm = new ProductManager();

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Product p)
    {
        ProductValidator productValidator = new ProductValidator();
        var check=productValidator.CheckProductName(p);

        if (check)
        {
            pm.ProductAdd(p);
             
        }
        else
        {
            ViewBag.UrunAdiHatasi = false; 
            
        }
        
        
        return View();
    }
    

    
}