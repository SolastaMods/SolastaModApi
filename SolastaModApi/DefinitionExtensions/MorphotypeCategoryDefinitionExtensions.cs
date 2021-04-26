using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MorphotypeCategoryDefinitionExtensions
    {
        public static T SetChoiceForm<T>(this T definition, MorphotypeCategoryDefinition.Form value)
            where T : MorphotypeCategoryDefinition
        {
            definition.SetField("choiceForm", value);
            return definition;
        }
    }
}