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
    [ControllerToolboxItem(Name = "CategoryInformation", Title = "Category Information", SectionName = "MasterClass")]
    public class CategoryInformationController : Controller
    {
        public ActionResult Index()
        {
            UCommerce.EntitiesV2.Category category = SiteContext.Current.CatalogContext.CurrentCategory;

            return View(MapCategory(category));
        }

        private CategoryViewModel MapCategory(UCommerce.EntitiesV2.Category category)
        {
            return new CategoryViewModel()
            {
            };
        }

        private ProductViewModel MapProduct(UCommerce.EntitiesV2.Product product)
        {
            return new ProductViewModel();
        }
    }
}