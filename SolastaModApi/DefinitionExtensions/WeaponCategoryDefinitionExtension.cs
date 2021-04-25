using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class WeaponCategoryDefinitionExtensions
    {
        public static void SetCategoryChoice(this WeaponCategoryDefinition definition, WeaponCategoryDefinition.CategoryChoiceEnum value)
        {
            definition.SetField("categoryChoice", value);
        }
    }
}