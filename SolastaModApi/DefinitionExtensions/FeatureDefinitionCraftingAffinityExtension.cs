using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCraftingAffinityExtensions
    {
        public static void SetAffinityGroups(this FeatureDefinitionCraftingAffinity definition, List<FeatureDefinitionCraftingAffinity.CraftingAffinityGroup> value)
        {
            definition.SetField("affinityGroups", value);
        }
    }
}