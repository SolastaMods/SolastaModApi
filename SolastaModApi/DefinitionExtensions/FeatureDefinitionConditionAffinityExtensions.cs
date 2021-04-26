using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionConditionAffinityExtensions
    {
        public static T SetConditionAffinityType<T>(this T definition, ConditionAffinityType value)
            where T : FeatureDefinitionConditionAffinity
        {
            definition.SetField("conditionAffinityType", value);
            return definition;
        }

        public static T SetConditionType<T>(this T definition, string value)
            where T : FeatureDefinitionConditionAffinity
        {
            definition.SetField("conditionType", value);
            return definition;
        }

        public static T SetRerollAdvantageType<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionConditionAffinity
        {
            definition.SetField("rerollAdvantageType", value);
            return definition;
        }

        public static T SetRerollSaveWhenGained<T>(this T definition, bool value)
            where T : FeatureDefinitionConditionAffinity
        {
            definition.SetField("rerollSaveWhenGained", value);
            return definition;
        }

        public static T SetSavingThrowAdvantageType<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionConditionAffinity
        {
            definition.SetField("savingThrowAdvantageType", value);
            return definition;
        }

        public static T SetSavingThrowModifier<T>(this T definition, int value)
            where T : FeatureDefinitionConditionAffinity
        {
            definition.SetField("savingThrowModifier", value);
            return definition;
        }
    }
}