using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionFactionChangeExtensions
    {
        public static FeatureDefinitionFactionChange SetChangeMode(this FeatureDefinitionFactionChange definition, FeatureDefinitionFactionChange.Mode value)
        {
            definition.SetField("changeMode", value);
            return definition;
        }

        public static FeatureDefinitionFactionChange SetSpecificFactionName(this FeatureDefinitionFactionChange definition, string value)
        {
            definition.SetField("specificFactionName", value);
            return definition;
        }

        public static FeatureDefinitionFactionChange SetTotalControl(this FeatureDefinitionFactionChange definition, bool value)
        {
            definition.SetField("totalControl", value);
            return definition;
        }
    }
}