using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSavingThrowAffinityExtensions
    {
        public static FeatureDefinitionSavingThrowAffinity SetAffinityGroups(this FeatureDefinitionSavingThrowAffinity definition, List<FeatureDefinitionSavingThrowAffinity.SavingThrowAffinityGroup> value)
        {
            definition.SetField("affinityGroups", value);
            return definition;
        }
    }
}