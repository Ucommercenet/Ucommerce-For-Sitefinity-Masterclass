using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCommerce.Infrastructure.Globalization;

namespace Ucommerce.MasterClass.Integration.Globalization
{
    public class LanguageService : ILanguageService
    {
        public IList<Language> GetAllLanguages()
        {
            return new List<Language>()
            {
                new Language("da-DK", "da-DK")
            };
        }
    }
}
