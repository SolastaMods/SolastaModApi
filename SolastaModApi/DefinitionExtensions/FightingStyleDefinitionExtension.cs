using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FightingStyleDefinitionExtensions
    {
        public static FightingStyleDefinition SetCondition(this FightingStyleDefinition definition, FightingStyleDefinition.TriggerCondition value)
        {
            definition.SetField("condition", value);
            return definition;
        }

        public static FightingStyleDefinition SetFeatures(this FightingStyleDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
            return definition;
        }
    }
}