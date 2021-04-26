using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionCraftingAffinityExtensions
    {
        public static T SetAffinityGroups<T>(this T definition, List<FeatureDefinitionCraftingAffinity.CraftingAffinityGroup> value)
            where T : FeatureDefinitionCraftingAffinity
        {
            definition.SetField("affinityGroups", value);
            return definition;
        }
    }
}