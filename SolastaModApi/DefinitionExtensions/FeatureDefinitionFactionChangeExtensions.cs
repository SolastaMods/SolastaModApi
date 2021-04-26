using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionFactionChangeExtensions
    {
        public static T SetChangeMode<T>(this T definition, FeatureDefinitionFactionChange.Mode value)
            where T : FeatureDefinitionFactionChange
        {
            definition.SetField("changeMode", value);
            return definition;
        }

        public static T SetSpecificFactionName<T>(this T definition, string value)
            where T : FeatureDefinitionFactionChange
        {
            definition.SetField("specificFactionName", value);
            return definition;
        }

        public static T SetTotalControl<T>(this T definition, bool value)
            where T : FeatureDefinitionFactionChange
        {
            definition.SetField("totalControl", value);
            return definition;
        }
    }
}