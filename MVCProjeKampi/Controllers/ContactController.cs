using BusinessLayer.Concrete;
using BusinessLayer.ValidatonRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator validationRules = new ContactValidator(); 
        public ActionResult Index()
        {
            var contactValues = contactManager.GetContactList();
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues = contactManager.GetById(id);
            return View(contactValues);
        }
    }
}