using System;
using UCommerce.Infrastructure;
using UCommerce.Infrastructure.Globalization;

namespace Ucommerce.Masterclass.BusinessLogic.CatalogInstaller
{
    public class GenericHelpers
    {
        public static void DoForEachCulture(Action<string> toDo)
        {
            foreach (Language language in ObjectFactory.Instance.Resolve<ILanguageService>().GetAllLanguages())
            {
                toDo(language.CultureCode);
            }
        }
    }
}