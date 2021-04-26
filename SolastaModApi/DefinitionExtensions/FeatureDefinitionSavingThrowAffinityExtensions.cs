using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionSavingThrowAffinityExtensions
    {
        public static T SetAffinityGroups<T>(this T definition, List<FeatureDefinitionSavingThrowAffinity.SavingThrowAffinityGroup> value)
            where T : FeatureDefinitionSavingThrowAffinity
        {
            definition.SetField("affinityGroups", value);
            return definition;
        }
    }
}