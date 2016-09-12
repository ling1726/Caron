using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.ViewModels.Highlights
{
    public class HighlightViewModel
    {
        public int HightlightId { get; set; }
        public string Label { get; set; }
        public int HighlightCategoryId { get; set; }
    }
}
