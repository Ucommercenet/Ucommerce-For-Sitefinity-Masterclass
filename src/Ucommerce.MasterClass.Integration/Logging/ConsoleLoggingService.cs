using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCommerce.Infrastructure.Logging;

namespace Ucommerce.MasterClass.Integration.Logging
{
    public class ConsoleLoggingService : ILoggingService
    {
        public void Log<T>(string customMessage)
        {
            Console.WriteLine(customMessage);
        }

        public void Log<T>(Exception exception)
        {
            Console.WriteLine(exception);
        }

        public void Log<T>(Exception exception, string customMessage)
        {
            Console.WriteLine(customMessage);
            Console.WriteLine(exception);
        }
    }
}
