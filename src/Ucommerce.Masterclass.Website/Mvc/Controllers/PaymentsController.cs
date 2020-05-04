using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Ucommerce.Masterclass.Website.Mvc.Models;
using UCommerce.Api;
using UCommerce.EntitiesV2;

namespace Ucommerce.Masterclass.Website.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Payment", Title = "Payment", SectionName = "MasterClass")]
    public class PaymentsController : Controller
    {
        public ActionResult Index()
        {
            var paymentViewModel = new PaymentViewModel();

            PurchaseOrder basket = UCommerce.Api.TransactionLibrary.GetBasket(false).PurchaseOrder;

            Country shippingCountry = UCommerce.Api.TransactionLibrary.GetShippingInformation().Country;

            var availablePaymentMethods = UCommerce.Api.TransactionLibrary.GetPaymentMethods(shippingCountry);

            var existingPayment = basket.Payments.FirstOrDefault();

            paymentViewModel.SelectedPaymentMethodId = existingPayment != null
                ? existingPayment.PaymentMethod.PaymentMethodId
                : -1;

            foreach (var availablePaymentMethod in availablePaymentMethods)
            {
                var option = new SelectListItem();
                option.Text = availablePaymentMethod.Name;
                option.Value = availablePaymentMethod.PaymentMethodId.ToString();
                option.Selected = availablePaymentMethod.PaymentMethodId == paymentViewModel.SelectedPaymentMethodId;

                paymentViewModel.AvailablePaymentMethods.Add(option);
            }

            return View(paymentViewModel);
        }

        [HttpPost]
        public ActionResult Index(PaymentViewModel payment)
        {
            return Redirect("/home/preview");
        }
    }
}