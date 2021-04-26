using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FightingStyleDefinitionExtensions
    {
        public static T SetCondition<T>(this T definition, FightingStyleDefinition.TriggerCondition value)
            where T : FightingStyleDefinition
        {
            definition.SetField("condition", value);
            return definition;
        }

        public static T SetFeatures<T>(this T definition, List<FeatureDefinition> value)
            where T : FightingStyleDefinition
        {
            definition.SetField("features", value);
            return definition;
        }
    }
}