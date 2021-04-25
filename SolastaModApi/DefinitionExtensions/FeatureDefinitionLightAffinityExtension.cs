using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionLightAffinityExtensions
    {
        public static FeatureDefinitionLightAffinity SetLightingEffectAndConditionList(this FeatureDefinitionLightAffinity definition, List<FeatureDefinitionLightAffinity.LightingEffectAndCondition> value)
        {
            definition.SetField("lightingEffectAndConditionList", value);
            return definition;
        }
    }
}