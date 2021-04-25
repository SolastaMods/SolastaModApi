using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MerchantCategoryDefinitionExtensions
    {
        public static void SetAssignableToItem(this MerchantCategoryDefinition definition, Boolean value)
        {
            definition.SetField("assignableToItem", value);
        }
    }
}