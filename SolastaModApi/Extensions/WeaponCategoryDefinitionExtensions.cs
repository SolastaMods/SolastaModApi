using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
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