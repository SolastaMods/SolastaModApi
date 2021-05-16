using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(WeaponCategoryDefinition))]
    public static class WeaponCategoryDefinitionExtensions
    {
        public static T SetCategoryChoice<T>(this T entity, WeaponCategoryDefinition.CategoryChoiceEnum value)
            where T : WeaponCategoryDefinition
        {
            entity.SetField("categoryChoice", value);
            return entity;
        }
    }
}