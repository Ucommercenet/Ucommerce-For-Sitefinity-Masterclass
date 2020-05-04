using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Ucommerce.Masterclass.Website.Mvc.Models;
using UCommerce.Api;
using UCommerce.Runtime;

namespace Ucommerce.Masterclass.Website.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "ProductInformation", Title = "Product Information", SectionName = "MasterClass")]
    public class ProductInformationController : Controller
    {
        public ActionResult Index()
        {
            var currentProduct = SiteContext.Current.CatalogContext.CurrentProduct;

            return View(MapProduct(currentProduct));
        }

        public ProductViewModel MapProduct(UCommerce.EntitiesV2.Product product)
        {
            var productViewModel = new ProductViewModel()
            {

            };

            return productViewModel;
        }

        [HttpPost]
        public ActionResult Index(AddToBasketViewModel model)
        {
            return Redirect(Request.Url.ToString());
        }
    }
}