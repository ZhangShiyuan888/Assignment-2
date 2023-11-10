using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2.Data;
using Assignment2.Models;
using static Assignment2.Models.ProductIndexViewModel;
using PagedList;

namespace Assignment2.Controllers
{
    public class ProductsController : Controller
    {
        private Assignment2Context db = new Assignment2Context();

        public ActionResult Index(string category, string search, int? page, String sortBy)
        {

            //instantiate a new view model
            ProductIndexViewModel viewModel = new ProductIndexViewModel();
            var products = db.Products.Include(p => p.Category);
            //perform the search and save the search string to the viewModel
            if (!String.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name.Contains(search) ||
                p.Description.Contains(search) ||
               p.Category.Name.Contains(search));
                viewModel.Search = search;
            }

            viewModel.CatsWithCount = from matchingProducts in products
                                      where matchingProducts.CategoryID != null
                                      group matchingProducts by
                                      matchingProducts.Category.Name into
                                       catGroup
                                      select new CategoryWithCount()
                                      {
                                          CategoryName = catGroup.Key,
                                          ProductCount = catGroup.Count()
                                      };
            if (!String.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category.Name == category);
                viewModel.Category = category;
            }
            switch (sortBy)
            {
                case "price_lowest":
                    products = products.OrderBy(p => p.Price);
                    break;
                case "price_highest":
                    products = products.OrderByDescending(p => p.Price);
                    break;
                default:
                    products = products.OrderBy(p => p.Name);
                    break;
            }
            //viewModel.Products = products; 
            viewModel.SortBy = sortBy;
            viewModel.Sorts = new Dictionary<string, string>
{
{"Release date early to late", "price_lowest" },
{"Release date late to early", "price_highest" }
};
            const int PageItems = 3;
            int currentPage = (page ?? 1);
            viewModel.Products = products.ToPagedList(currentPage, PageItems);
            return View(viewModel);
        }




        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name");
            return View();
        }

        // POST: Products/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Price,Description,CategoryID")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // POST: Products/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Price,Description,CategoryID")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
