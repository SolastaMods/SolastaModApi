using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionConditionAffinityExtensions
    {
        public static void SetConditionAffinityType(this FeatureDefinitionConditionAffinity definition, ConditionAffinityType value)
        {
            definition.SetField("conditionAffinityType", value);
        }

        public static void SetConditionType(this FeatureDefinitionConditionAffinity definition, String value)
        {
            definition.SetField("conditionType", value);
        }

        public static void SetRerollAdvantageType(this FeatureDefinitionConditionAffinity definition, AdvantageType value)
        {
            definition.SetField("rerollAdvantageType", value);
        }

        public static void SetRerollSaveWhenGained(this FeatureDefinitionConditionAffinity definition, Boolean value)
        {
            definition.SetField("rerollSaveWhenGained", value);
        }

        public static void SetSavingThrowAdvantageType(this FeatureDefinitionConditionAffinity definition, AdvantageType value)
        {
            definition.SetField("savingThrowAdvantageType", value);
        }

        public static void SetSavingThrowModifier(this FeatureDefinitionConditionAffinity definition, Int32 value)
        {
            definition.SetField("savingThrowModifier", value);
        }
    }
}