using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionDeathSavingThrowAffinityExtensions
    {
        public static void SetAdvantageType(this FeatureDefinitionDeathSavingThrowAffinity definition, AdvantageType value)
        {
            definition.SetField("advantageType", value);
        }

        public static void SetRegainHitDieOnStabilize(this FeatureDefinitionDeathSavingThrowAffinity definition, Boolean value)
        {
            definition.SetField("regainHitDieOnStabilize", value);
        }
    }
}