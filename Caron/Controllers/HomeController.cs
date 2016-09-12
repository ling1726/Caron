using Caron.BusinessLogic;
using Caron.DAL.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caron.Controllers
{
    public class HomeController : BaseController
    {
        public HomeBll BusinessLogic => new HomeBll(Db);
        public ActionResult Index()
        {
            var viewModel = BusinessLogic.RenderIndex();
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult CreateSection()
        {
            // TODO create the partial view to create a description section
            var viewModel = new DescriptionSectionViewModel();
            return PartialView("_CreateDescriptionSection", viewModel);
        }
        [HttpPost]
        public ActionResult CreateSection(DescriptionSectionViewModel viewModel)
        {
            BusinessLogic.CreateDescriptionSection(viewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateDescriptionSection(int descriptionSectionId)
        {
            var viewModel = BusinessLogic.UpdateDescriptionSection(descriptionSectionId);
            return PartialView("_UpdateDescriptionSection", viewModel);
        }

        [HttpPost]
        public ActionResult UpdateDescriptionSection(DescriptionSectionViewModel viewModel)
        {
            BusinessLogic.UpdateDescriptionSection(viewModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteDescriptionSection(int descriptionSectionId)
        {
            BusinessLogic.DeleteDescriptionSection(descriptionSectionId);
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}