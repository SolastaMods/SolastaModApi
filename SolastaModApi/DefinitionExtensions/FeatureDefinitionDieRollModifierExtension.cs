using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionDieRollModifierExtensions
    {
        public static void SetMaxRollValue(this FeatureDefinitionDieRollModifier definition, Int32 value)
        {
            definition.SetField("maxRollValue", value);
        }

        public static void SetMinRerollValue(this FeatureDefinitionDieRollModifier definition, Int32 value)
        {
            definition.SetField("minRerollValue", value);
        }

        public static void SetMinRollValue(this FeatureDefinitionDieRollModifier definition, Int32 value)
        {
            definition.SetField("minRollValue", value);
        }

        public static void SetRerollCount(this FeatureDefinitionDieRollModifier definition, Int32 value)
        {
            definition.SetField("rerollCount", value);
        }

        public static void SetRerollLocalizationKey(this FeatureDefinitionDieRollModifier definition, String value)
        {
            definition.SetField("rerollLocalizationKey", value);
        }

        public static void SetValidityContext(this FeatureDefinitionDieRollModifier definition, RollContext value)
        {
            definition.SetField("validityContext", value);
        }
    }
}