using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class WeaponCategoryDefinitionExtensions
    {
        public static T SetCategoryChoice<T>(this T definition, WeaponCategoryDefinition.CategoryChoiceEnum value)
            where T : WeaponCategoryDefinition
        {
            definition.SetField("categoryChoice", value);
            return definition;
        }
    }
}