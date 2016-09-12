using Caron.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caron.Controllers
{
    public class HighlightsController : BaseController
    {
        private HighlightsBll BusinessLogic => new HighlightsBll(Db);
        // GET: Highlights
        public ActionResult Index()
        {
            var viewModel = BusinessLogic.RenderIndex();
            return View(viewModel);
        }

        public ActionResult CreateHighlightCategory(string label)
        {
            BusinessLogic.CreateHighlightCategory(label);
            return RedirectToAction("Index");
        }

        public ActionResult CreateHighlight(string label, int highlightCategoryId)
        {
            BusinessLogic.CreateHighlight(label, highlightCategoryId);
            return RedirectToAction("Index");
        }
    }
}