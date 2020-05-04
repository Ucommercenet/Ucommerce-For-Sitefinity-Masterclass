using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCommerce.EntitiesV2;
using UCommerce.Pipelines;
using UCommerce.Pipelines.Initialization;

namespace Ucommerce.Masterclass.BusinessLogic.CatalogInstaller
{
    public class InstallCatalogPipelineTask : IPipelineTask<InitializeArgs>
    {
        public PipelineExecutionResult Execute(InitializeArgs subject)
        {
            if (ProductCatalogGroup.All().Any(x => x.Name == "avenue-clothing.com"))
                return PipelineExecutionResult.Success;
            
            new ConfigurationInstaller().Configure();
            new CatalogueInstaller("avenue-clothing.com", "Demo Store").Configure();
            
            var group = ProductCatalogGroup.SingleOrDefault(g => g.Name == "uCommerce.dk");
            if (group != null)
            {
                // Delete products in group
                foreach (
                    var relation in
                    CategoryProductRelation.All()
                        .Where(x => group.ProductCatalogs.Contains(x.Category.ProductCatalog))
                        .ToList())
                {
                    var category = relation.Category;
                    var product = relation.Product;
                    category.RemoveProduct(product);
                    product.Delete();
                }

                // Delete catalogs
                foreach (var catalog in group.ProductCatalogs)
                {
                    catalog.Deleted = true;
                }

                // Delete group itself
                group.Deleted = true;
                group.Save();
            }

            return PipelineExecutionResult.Success;
        }
    }
}
