using System.Collections.Generic;

namespace Ucommerce.Masterclass.Website.Mvc.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Variants = new List<ProductViewModel>();
        }
        public string Name { get; set; }
        public string Url { get; set; }

        public string Sku { get; set; }

        public string VariantSku { get; set; }

        public string Price { get; set; }

        public IList<ProductViewModel> Variants { get; set; }
    }

    public class AddToBasketViewModel
    {
        public string Sku { get; set; }

        public string VariantSku { get; set; }
    }
}