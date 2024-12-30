using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;
public class HomeController : Controller
{
    OrganicContext context;
    public HomeController(OrganicContext context)
    {
        this.context = context;
    }
    public IActionResult Index()
    {
        ViewBag.Departments = context.Departments.ToList();

        ViewBag.Categories = context.Categories.ToList();
        return View(context.Products.ToList());
    }

    public IActionResult Details(int id)
    {
        Product? product = context.Products.Find(id);
        if (product is null)
        {
            return Redirect("/");
        }
        ViewBag.Departments = context.Departments.ToList();

        ViewBag.Categories = context.Categories.ToList();

        ViewBag.ProductsRelation = context.Products.Where(p => p.CategoryId == product.CategoryId && p.ProductId != id);

        return View(product);
    }


}