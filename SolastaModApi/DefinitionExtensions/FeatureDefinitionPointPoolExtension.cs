using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionPointPoolExtensions
    {
        public static FeatureDefinitionPointPool SetPoolAmount(this FeatureDefinitionPointPool definition, int value)
        {
            definition.SetField("poolAmount", value);
            return definition;
        }

        public static FeatureDefinitionPointPool SetPoolType(this FeatureDefinitionPointPool definition, HeroDefinitions.PointsPoolType value)
        {
            definition.SetField("poolType", value);
            return definition;
        }

        public static FeatureDefinitionPointPool SetRestrictedChoices(this FeatureDefinitionPointPool definition, List<string> value)
        {
            definition.SetField("restrictedChoices", value);
            return definition;
        }

        public static FeatureDefinitionPointPool SetUniqueChoices(this FeatureDefinitionPointPool definition, bool value)
        {
            definition.SetField("uniqueChoices", value);
            return definition;
        }
    }
}