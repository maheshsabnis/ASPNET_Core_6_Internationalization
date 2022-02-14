using Microsoft.AspNetCore.Mvc;
using Core6_Internationalization.Models;
using Core6_Internationalization.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
namespace Core6_Internationalization.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productService;
        private List<SelectListItem> categories;
        private List<SelectListItem> manufactureres;
        private readonly IStringLocalizer<ProductController>? _localizer;
        public ProductController(ProductService productService, IStringLocalizer<ProductController>? localizer)
        {
            _localizer = localizer;
            this.productService = productService;
            categories = new List<SelectListItem>() {
              new SelectListItem(localizer["Electronics"], localizer["Electronics"]),
              new SelectListItem(localizer["Electrical"],  localizer["Electrical"]),
              new SelectListItem(localizer["Food"],  localizer["Food"])
            };
            manufactureres = new List<SelectListItem>() {
                new SelectListItem(localizer["MS-Eletronics"], localizer["MS-Eletronics"]),
                new SelectListItem(localizer["MS-Electrical"], localizer["MS-Electrical"]),
                new SelectListItem(localizer["MS-Food"], localizer["MS-Food"]),
                new SelectListItem(localizer["LS-Eletronics"], localizer["LS-Eletronics"]),
                new SelectListItem(localizer["LS-Electrical"], localizer["LS-Electrical"]),
                new SelectListItem(localizer["LS-Food"], localizer["LS-Food"]),
                new SelectListItem(localizer["TS-Eletronics"], localizer["TS-Eletronics"]),
                new SelectListItem(localizer["TS-Electrical"], localizer["TS-Electrical"]),
                new SelectListItem(localizer["TS-Food"], localizer["TS-Food"])
            };
        }
        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }

        public IActionResult Create()
        {
            var product = new Product();
            
            ViewBag.CategoryName = categories;
            ViewBag.Manufacturer = manufactureres;
            return View(product);
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var products = productService.AddProducts(product);
                return View("Index", products);
            }
            else
            {
                ViewBag.CategoryName = categories;
                ViewBag.Manufacturer = manufactureres;
                return View(product);
            }
        }
    }
}
