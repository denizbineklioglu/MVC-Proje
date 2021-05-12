using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        IstatistikManager istatistikManager = new IstatistikManager();
        public ActionResult Index()
        {
            int categoryCount = istatistikManager.CountCategory();
            ViewBag.CategoryCount = categoryCount;

            int headingCount = istatistikManager.CountHeading();
            ViewBag.HeadingCount = headingCount;

            int writerCount = istatistikManager.CountWriter();
            ViewBag.WriterCount = writerCount;

            string categoryName = istatistikManager.MaxCategory();
            ViewBag.MaxCategory = categoryName;

            int countStatus = istatistikManager.CountStatus();
            ViewBag.StatusCount = countStatus;

            return View();
        }
    }
}