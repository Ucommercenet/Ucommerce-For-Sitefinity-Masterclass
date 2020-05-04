using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ucommerce.Masterclass.Website.Mvc.Models
{
    public partial class CategoryNavigationRenderingViewModel
    {
        public CategoryNavigationRenderingViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }
        public IList<CategoryViewModel> Categories { get; set; }
    }
}