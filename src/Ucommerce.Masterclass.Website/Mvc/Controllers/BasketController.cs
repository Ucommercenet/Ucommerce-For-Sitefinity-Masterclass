using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Ucommerce.Masterclass.Website.Mvc.Models;
using UCommerce;
using UCommerce.Runtime;

namespace Ucommerce.Masterclass.Website.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Basket", Title = "Basket", SectionName = "MasterClass")]
    public class BasketController : Controller
    {
        public ActionResult Index()
        {
            var basketModel = new Ucommerce.Masterclass.Website.Mvc.Models.BasketViewModel();

            return View(basketModel);
        }

        [HttpPost]
        public ActionResult Index(BasketViewModel model)
        {
            return Redirect(Request.Url.ToString());
        }
    }
}