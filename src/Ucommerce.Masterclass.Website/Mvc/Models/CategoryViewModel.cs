using System;
using System.Collections.Generic;

namespace Ucommerce.Masterclass.Website.Mvc.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            ProductItemGuids = new List<Guid>();
            Categories = new List<CategoryViewModel>();
        }

        public IList<Guid> ProductItemGuids { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public IList<CategoryViewModel> Categories { get; set; }

        public IList<ProductViewModel> Products { get; set; }
    }
}