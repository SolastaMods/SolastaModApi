using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MorphotypeCategoryDefinitionExtensions
    {
        public static void SetChoiceForm(this MorphotypeCategoryDefinition definition, MorphotypeCategoryDefinition.Form value)
        {
            definition.SetField("choiceForm", value);
        }
    }
}