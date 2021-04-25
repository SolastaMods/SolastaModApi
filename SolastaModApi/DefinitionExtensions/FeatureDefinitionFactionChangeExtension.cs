using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionFactionChangeExtensions
    {
        public static void SetChangeMode(this FeatureDefinitionFactionChange definition, FeatureDefinitionFactionChange.Mode value)
        {
            definition.SetField("changeMode", value);
        }

        public static void SetSpecificFactionName(this FeatureDefinitionFactionChange definition, String value)
        {
            definition.SetField("specificFactionName", value);
        }

        public static void SetTotalControl(this FeatureDefinitionFactionChange definition, Boolean value)
        {
            definition.SetField("totalControl", value);
        }
    }
}