using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class WeaponCategoryDefinitionExtensions
    {
        public static WeaponCategoryDefinition SetCategoryChoice(this WeaponCategoryDefinition definition, WeaponCategoryDefinition.CategoryChoiceEnum value)
        {
            definition.SetField("categoryChoice", value);
            return definition;
        }
    }
}