using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MerchantCategoryDefinitionExtensions
    {
        public static T SetAssignableToItem<T>(this T definition, bool value)
            where T : MerchantCategoryDefinition
        {
            definition.SetField("assignableToItem", value);
            return definition;
        }
    }
}