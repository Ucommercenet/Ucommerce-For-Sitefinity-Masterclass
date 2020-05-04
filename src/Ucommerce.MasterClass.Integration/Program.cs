using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCommerce.EntitiesV2;
using UCommerce.Infrastructure;

namespace Ucommerce.MasterClass.Integration
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = PurchaseOrder.All().FirstOrDefault();
        }
    }
}
