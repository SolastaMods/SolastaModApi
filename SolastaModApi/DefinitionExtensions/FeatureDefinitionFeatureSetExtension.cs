using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionFeatureSetExtensions
    {
        public static FeatureDefinitionFeatureSet SetDefaultSelection(this FeatureDefinitionFeatureSet definition, int value)
        {
            definition.SetField("defaultSelection", value);
            return definition;
        }

        public static FeatureDefinitionFeatureSet SetEnumerateInDescription(this FeatureDefinitionFeatureSet definition, bool value)
        {
            definition.SetField("enumerateInDescription", value);
            return definition;
        }

        public static FeatureDefinitionFeatureSet SetFeatureSet(this FeatureDefinitionFeatureSet definition, List<FeatureDefinition> value)
        {
            definition.SetField("featureSet", value);
            return definition;
        }

        public static FeatureDefinitionFeatureSet SetMode(this FeatureDefinitionFeatureSet definition, FeatureDefinitionFeatureSet.FeatureSetMode value)
        {
            definition.SetField("mode", value);
            return definition;
        }

        public static FeatureDefinitionFeatureSet SetUniqueChoices(this FeatureDefinitionFeatureSet definition, bool value)
        {
            definition.SetField("uniqueChoices", value);
            return definition;
        }
    }
}