using MVCOnlineTicariOtomasyon.Models.DataAccess;
using MVCOnlineTicariOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class CategoryController : Controller
    {
        Context context = new Context();
        // GET: Category
        public ActionResult Index()
        {
            var degerler = context.Categories.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddCategory()
		{
            return View();
		}
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
		{
            var deletedCategory = context.Categories.Find(id);
            context.Categories.Remove(deletedCategory);
            context.SaveChanges();
            return RedirectToAction("Index");
		}
        public ActionResult GetCategory(int id)
		{
            var category = context.Categories.Find(id);
            return View("GetCategory",category);
		}
        public ActionResult UpdateCategory(Category c)
		{
            var updatedCategory = context.Categories.Find(c.CategoryId);
            updatedCategory.Name = c.Name;
            context.SaveChanges();
            return RedirectToAction("Index");
		}
    }
}