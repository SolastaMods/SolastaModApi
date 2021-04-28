using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionConditionAffinityExtensions
    {
        public static T SetConditionAffinityType<T>(this T entity, ConditionAffinityType value)
            where T : FeatureDefinitionConditionAffinity
        {
            entity.SetField("conditionAffinityType", value);
            return entity;
        }

        public static T SetConditionType<T>(this T entity, string value)
            where T : FeatureDefinitionConditionAffinity
        {
            entity.SetField("conditionType", value);
            return entity;
        }

        public static T SetRerollAdvantageType<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionConditionAffinity
        {
            entity.SetField("rerollAdvantageType", value);
            return entity;
        }

        public static T SetRerollSaveWhenGained<T>(this T entity, bool value)
            where T : FeatureDefinitionConditionAffinity
        {
            entity.SetField("rerollSaveWhenGained", value);
            return entity;
        }

        public static T SetSavingThrowAdvantageType<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionConditionAffinity
        {
            entity.SetField("savingThrowAdvantageType", value);
            return entity;
        }

        public static T SetSavingThrowModifier<T>(this T entity, int value)
            where T : FeatureDefinitionConditionAffinity
        {
            entity.SetField("savingThrowModifier", value);
            return entity;
        }
    }
}