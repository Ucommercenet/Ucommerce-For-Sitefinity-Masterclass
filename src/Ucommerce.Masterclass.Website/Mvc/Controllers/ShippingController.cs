using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Ucommerce.Masterclass.Website.Mvc.Models;
using UCommerce.Api;

namespace Ucommerce.Masterclass.Website.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Shipping", Title = "Shipping", SectionName = "MasterClass")]
    public class ShippingController : Controller
    {
        public ActionResult Index()
        {
            var shippingModel = new ShippingViewModel();

            return View(shippingModel);
        }

        [HttpPost]
        public ActionResult Index(ShippingViewModel model)
        {
            return Redirect("/home/payment");
        }
    }
}