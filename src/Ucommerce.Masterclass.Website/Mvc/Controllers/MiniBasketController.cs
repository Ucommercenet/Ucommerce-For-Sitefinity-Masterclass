using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Ucommerce.Masterclass.Website.Mvc.Models;
using UCommerce;
using UCommerce.Api;

namespace Ucommerce.Masterclass.Website.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "MiniBasket", Title = "MiniBasket", SectionName = "MasterClass")]
    public class MiniBasketController : Controller
    {
        public ActionResult Index()
        {
            if (!TransactionLibrary.HasBasket())
            {
                return View(new MiniBasketModel() { HasBasket = false});
            };

            var basket = TransactionLibrary.GetBasket(false).PurchaseOrder;

            return View(new MiniBasketModel()
            {
                HasBasket = true,
                NumberOfItemsInBasket = basket.OrderLines.Sum(x => x.Quantity),
                OrderTotal = new Money(basket.OrderTotal.GetValueOrDefault(), basket.BillingCurrency).ToString()
            });
        }
    }
}