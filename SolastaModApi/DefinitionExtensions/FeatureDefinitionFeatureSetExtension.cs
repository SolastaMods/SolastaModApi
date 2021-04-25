using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionFeatureSetExtensions
    {
        public static void SetDefaultSelection(this FeatureDefinitionFeatureSet definition, Int32 value)
        {
            definition.SetField("defaultSelection", value);
        }

        public static void SetEnumerateInDescription(this FeatureDefinitionFeatureSet definition, Boolean value)
        {
            definition.SetField("enumerateInDescription", value);
        }

        public static void SetFeatureSet(this FeatureDefinitionFeatureSet definition, List<FeatureDefinition> value)
        {
            definition.SetField("featureSet", value);
        }

        public static void SetMode(this FeatureDefinitionFeatureSet definition, FeatureDefinitionFeatureSet.FeatureSetMode value)
        {
            definition.SetField("mode", value);
        }

        public static void SetUniqueChoices(this FeatureDefinitionFeatureSet definition, Boolean value)
        {
            definition.SetField("uniqueChoices", value);
        }
    }
}