using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionDeathSavingThrowAffinityExtensions
    {
        public static FeatureDefinitionDeathSavingThrowAffinity SetAdvantageType(this FeatureDefinitionDeathSavingThrowAffinity definition, AdvantageType value)
        {
            definition.SetField("advantageType", value);
            return definition;
        }

        public static FeatureDefinitionDeathSavingThrowAffinity SetRegainHitDieOnStabilize(this FeatureDefinitionDeathSavingThrowAffinity definition, bool value)
        {
            definition.SetField("regainHitDieOnStabilize", value);
            return definition;
        }
    }
}