using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCommerce.Infrastructure.Configuration;

namespace Ucommerce.MasterClass.Integration.DataAccess
{
    public class ConsoleConnectionStringLocator : ConnectionStringLocator
    {
        public override string LocateConnectionString()
        {
            return base.LocateConnectionStringInternal("Ucommerce");
        }
    }
}
