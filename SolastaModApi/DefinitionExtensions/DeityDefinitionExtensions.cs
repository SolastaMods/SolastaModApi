using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DeityDefinitionExtensions
    {
        public static T SetAlignment<T>(this T definition, string value)
            where T : DeityDefinition
        {
            definition.SetField("alignment", value);
            return definition;
        }

        public static T SetSelectableByPlayer<T>(this T definition, bool value)
            where T : DeityDefinition
        {
            definition.SetField("selectableByPlayer", value);
            return definition;
        }
    }
}