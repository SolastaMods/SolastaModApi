using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionLightAffinityExtensions
    {
        public static T SetLightingEffectAndConditionList<T>(this T definition, List<FeatureDefinitionLightAffinity.LightingEffectAndCondition> value)
            where T : FeatureDefinitionLightAffinity
        {
            definition.SetField("lightingEffectAndConditionList", value);
            return definition;
        }
    }
}