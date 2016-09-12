using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.ViewModels.Highlights
{
    public class HightlightsIndexViewModel
    {
        private List<HighlightCategoryViewModel> highlightCategories;
        private List<HighlightViewModel> highlights;

        public HightlightsIndexViewModel()
        {
            Highlights = new Dictionary<HighlightCategoryViewModel, List<HighlightViewModel>>();
        }

        public HightlightsIndexViewModel(List<HighlightCategoryViewModel> highlightCategories, List<HighlightViewModel> highlights)
        {
            this.highlightCategories = highlightCategories;
            this.highlights = highlights;
            foreach (var category in highlightCategories)
            {
                Highlights.Add(category, new List<HighlightViewModel>());
                Highlights[category].AddRange(highlights.Where(x => x.HighlightCategoryId == category.HighlightCategoryId).ToList());
            }
        }

        public Dictionary<HighlightCategoryViewModel, List<HighlightViewModel>> Highlights { get; set; }
    }
}
