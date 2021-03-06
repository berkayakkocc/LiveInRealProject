using Business.Concrete;
using Business.FluentValidation;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveInRealProject.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {

            ProductValidator validationRules = new ProductValidator();
            ValidationResult results = validationRules.Validate(product);
            if (results.IsValid)
            {
                productManager.Add(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = productManager.GetById(id);
            productManager.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = productManager.GetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            productManager.Update(product);
            return RedirectToAction("Index");
        }
    }
}
