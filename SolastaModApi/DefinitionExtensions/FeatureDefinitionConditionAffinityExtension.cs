using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionConditionAffinityExtensions
    {
        public static FeatureDefinitionConditionAffinity SetConditionAffinityType(this FeatureDefinitionConditionAffinity definition, ConditionAffinityType value)
        {
            definition.SetField("conditionAffinityType", value);
            return definition;
        }

        public static FeatureDefinitionConditionAffinity SetConditionType(this FeatureDefinitionConditionAffinity definition, string value)
        {
            definition.SetField("conditionType", value);
            return definition;
        }

        public static FeatureDefinitionConditionAffinity SetRerollAdvantageType(this FeatureDefinitionConditionAffinity definition, AdvantageType value)
        {
            definition.SetField("rerollAdvantageType", value);
            return definition;
        }

        public static FeatureDefinitionConditionAffinity SetRerollSaveWhenGained(this FeatureDefinitionConditionAffinity definition, bool value)
        {
            definition.SetField("rerollSaveWhenGained", value);
            return definition;
        }

        public static FeatureDefinitionConditionAffinity SetSavingThrowAdvantageType(this FeatureDefinitionConditionAffinity definition, AdvantageType value)
        {
            definition.SetField("savingThrowAdvantageType", value);
            return definition;
        }

        public static FeatureDefinitionConditionAffinity SetSavingThrowModifier(this FeatureDefinitionConditionAffinity definition, int value)
        {
            definition.SetField("savingThrowModifier", value);
            return definition;
        }
    }
}