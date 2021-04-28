using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionDeathSavingThrowAffinityExtensions
    {
        public static T SetAdvantageType<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionDeathSavingThrowAffinity
        {
            entity.SetField("advantageType", value);
            return entity;
        }

        public static T SetRegainHitDieOnStabilize<T>(this T entity, bool value)
            where T : FeatureDefinitionDeathSavingThrowAffinity
        {
            entity.SetField("regainHitDieOnStabilize", value);
            return entity;
        }
    }
}