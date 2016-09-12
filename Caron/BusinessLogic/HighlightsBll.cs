using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Caron.DAL.Models;
using Caron.DAL.ViewModels.Highlights;

namespace Caron.BusinessLogic
{
    public class HighlightsBll : BaseBll
    {
        public HighlightsBll(CaronEntities db) : base(db)
        {
        }

        public HightlightsIndexViewModel RenderIndex()
        {
            var highlightCategories = Db.HighlightCategories.Select(x => new HighlightCategoryViewModel
            {
                HighlightCategoryId = x.HighLightCategoryId,
                Label = x.Label
            }).ToList();

            var highlights = Db.Highlights.Select(x => new HighlightViewModel
            {
                HighlightCategoryId = x.HightLightCategory.HighLightCategoryId,
                HightlightId = x.HighLightId,
                Label = x.Label
            }).ToList();

            var viewModel = new HightlightsIndexViewModel(highlightCategories, highlights);

            return viewModel;
        }

        public void CreateHighlight(string label, int highlightCategoryId)
        {
            var newHighlight = new Highlight
            {
                HighLightCategoryId = highlightCategoryId,
                Label = label,
            };

            Db.Highlights.Add(newHighlight);
            Db.SaveChanges();
        }

        public void CreateHighlightCategory(string label)
        {
            var newCategory = new HighLightCategory
            {
                Label = label
            };

            Db.HighlightCategories.Add(newCategory);
            Db.SaveChanges();
        }
    }
}