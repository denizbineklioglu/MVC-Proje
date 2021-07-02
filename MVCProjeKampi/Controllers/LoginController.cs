using DataAccessLayer.Concrete;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminUser = c.Admins.FirstOrDefault(x=> x.AdminUserName == p.AdminUserName && 
            x.AdminPassword == p.AdminPassword);
            if (adminUser != null)
            {
                FormsAuthentication.SetAuthCookie(adminUser.AdminUserName,false);
                Session["AdminUserName"] = adminUser.AdminUserName;
                return RedirectToAction("Index","AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");    
            }
            return View();
        }




    }
}