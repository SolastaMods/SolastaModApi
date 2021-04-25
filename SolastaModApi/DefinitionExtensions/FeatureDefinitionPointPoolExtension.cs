using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionPointPoolExtensions
    {
        public static void SetPoolAmount(this FeatureDefinitionPointPool definition, Int32 value)
        {
            definition.SetField("poolAmount", value);
        }

        public static void SetPoolType(this FeatureDefinitionPointPool definition, HeroDefinitions.PointsPoolType value)
        {
            definition.SetField("poolType", value);
        }

        public static void SetRestrictedChoices(this FeatureDefinitionPointPool definition, List<String> value)
        {
            definition.SetField("restrictedChoices", value);
        }

        public static void SetUniqueChoices(this FeatureDefinitionPointPool definition, Boolean value)
        {
            definition.SetField("uniqueChoices", value);
        }
    }
}