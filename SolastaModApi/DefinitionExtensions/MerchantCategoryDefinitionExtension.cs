using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MerchantCategoryDefinitionExtensions
    {
        public static MerchantCategoryDefinition SetAssignableToItem(this MerchantCategoryDefinition definition, bool value)
        {
            definition.SetField("assignableToItem", value);
            return definition;
        }
    }
}