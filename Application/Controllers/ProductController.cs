using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Models;
using Application.Data;

namespace Application.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;


        public ProductController(ApplicationDbContext db)
        {
            this._db = db;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            IEnumerable<Product> objList = this._db.Product;
            return View(objList);
        }


        //GET - Create
        public ActionResult Create()
        {
            return View();
        }

        //GET - Edit
        public ActionResult Edit(int productId)
        {
            return View(this._db.Product.Find(productId));
        }



        //POST - Edit/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Product product)
        {
            var obj = this._db.Product.Find(product.ProductId);
            if ( obj != null)
            {
                obj.ProductName = product.ProductName;
                obj.OrderId = product.OrderId;
                obj.Quantity = product.Quantity;
                //this._db.Product.Update(product);
            }
            else
            {
                this._db.Product.Add(product);
            }
            this._db.SaveChanges();
            return RedirectToAction("Index");        
        }
        

        //Delete
        public IActionResult Delete(int productId)
        {
            this._db.Product.Remove(this._db.Product.Find(productId));
            this._db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}