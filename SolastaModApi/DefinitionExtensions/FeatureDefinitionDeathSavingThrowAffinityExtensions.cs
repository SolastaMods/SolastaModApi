using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionDeathSavingThrowAffinityExtensions
    {
        public static T SetAdvantageType<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionDeathSavingThrowAffinity
        {
            definition.SetField("advantageType", value);
            return definition;
        }

        public static T SetRegainHitDieOnStabilize<T>(this T definition, bool value)
            where T : FeatureDefinitionDeathSavingThrowAffinity
        {
            definition.SetField("regainHitDieOnStabilize", value);
            return definition;
        }
    }
}