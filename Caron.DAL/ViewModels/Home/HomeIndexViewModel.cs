using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caron.DAL.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            DescriptionSections = new List<DescriptionSectionViewModel>();
        }
        public List<DescriptionSectionViewModel> DescriptionSections { get; set; }
    }
}
