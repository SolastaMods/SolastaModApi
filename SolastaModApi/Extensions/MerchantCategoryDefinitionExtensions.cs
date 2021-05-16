using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(MerchantCategoryDefinition))]
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