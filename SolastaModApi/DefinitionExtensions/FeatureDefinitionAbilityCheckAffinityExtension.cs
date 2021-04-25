using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAbilityCheckAffinityExtensions
    {
        public static FeatureDefinitionAbilityCheckAffinity SetAffinityGroups(this FeatureDefinitionAbilityCheckAffinity definition, List<FeatureDefinitionAbilityCheckAffinity.AbilityCheckAffinityGroup> value)
        {
            definition.SetField("affinityGroups", value);
            return definition;
        }
    }
}