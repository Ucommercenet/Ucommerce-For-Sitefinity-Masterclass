using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Ucommerce.Masterclass.Website.Mvc.Models;
using UCommerce.Api;
using UCommerce.EntitiesV2;
using UCommerce.Extensions;
using UCommerce.Runtime;

namespace Ucommerce.Masterclass.Website.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "CategoryNavigation", Title = "Category Navigation", SectionName = "MasterClass")]
    public class CategoryNavigationController : Controller
    {
        public ActionResult Index()
        {
            ICollection<Category> categories = null;
            IList<CategoryViewModel> rootCategoryViewModels = MapCategories(categories);

            return View(new CategoryNavigationRenderingViewModel()
            {
                Categories = rootCategoryViewModels
            });
        }

        private IList<CategoryViewModel> MapCategories(ICollection<Category> categories)
        {
            var result = new List<CategoryViewModel>();

            return result;
        }
    }
}