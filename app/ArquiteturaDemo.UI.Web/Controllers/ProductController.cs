using System.Web.Mvc;
using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;
using ArquiteturaDemo.UI.Application;

namespace ArquiteturaDemo.UI.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductApplication _productApplication;
        private readonly IProductRepository _productRepository;

        public ProductController(ProductApplication productApplication, IProductRepository productRepository)
        {
            _productApplication = productApplication;
            _productRepository = productRepository;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productApplication.Register(product);

                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }
    }
}