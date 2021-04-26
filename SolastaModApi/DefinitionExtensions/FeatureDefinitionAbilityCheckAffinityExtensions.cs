using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionAbilityCheckAffinityExtensions
    {
        public static T SetAffinityGroups<T>(this T definition, List<FeatureDefinitionAbilityCheckAffinity.AbilityCheckAffinityGroup> value)
            where T : FeatureDefinitionAbilityCheckAffinity
        {
            definition.SetField("affinityGroups", value);
            return definition;
        }
    }
}