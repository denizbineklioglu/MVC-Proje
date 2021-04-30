using BusinessLayer.Concrete;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        //CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            //var categoryValues = categoryManager.GetAll();
            return View(); //degerler view'e aktarılır.
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            //categoryManager.CategoryAdd(category);
            return RedirectToAction("GetCategoryList");
        }
    }
}