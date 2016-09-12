using Caron.BusinessLogic;
using Caron.DAL.ViewModels.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caron.Controllers
{
    public class ContactController : BaseController
    {
        private ContactBll BusinessLogic => new ContactBll(Db);

        // GET: Contact
        public ActionResult Index()
        {
            var viewModel = new ContactViewModel(); 
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateContact(ContactViewModel viewModel)
        {
            BusinessLogic.CreateContact(viewModel);
            return RedirectToAction("Index");
        }

        public JsonResult ContactSubjectField()
        {
            var contactSubjects = Db.ContactSubjects.Select(x => new
            {
                id = x.ContactSubjectId,
                label = x.Label
            });

            return Json(contactSubjects, JsonRequestBehavior.AllowGet);
        }
    }
}