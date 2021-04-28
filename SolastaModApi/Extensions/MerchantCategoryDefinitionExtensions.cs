using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MerchantCategoryDefinitionExtensions
    {
        public static T SetAssignableToItem<T>(this T entity, bool value)
            where T : MerchantCategoryDefinition
        {
            entity.SetField("assignableToItem", value);
            return entity;
        }
    }
}