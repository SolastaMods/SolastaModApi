using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionDieRollModifierExtensions
    {
        public static FeatureDefinitionDieRollModifier SetMaxRollValue(this FeatureDefinitionDieRollModifier definition, int value)
        {
            definition.SetField("maxRollValue", value);
            return definition;
        }

        public static FeatureDefinitionDieRollModifier SetMinRerollValue(this FeatureDefinitionDieRollModifier definition, int value)
        {
            definition.SetField("minRerollValue", value);
            return definition;
        }

        public static FeatureDefinitionDieRollModifier SetMinRollValue(this FeatureDefinitionDieRollModifier definition, int value)
        {
            definition.SetField("minRollValue", value);
            return definition;
        }

        public static FeatureDefinitionDieRollModifier SetRerollCount(this FeatureDefinitionDieRollModifier definition, int value)
        {
            definition.SetField("rerollCount", value);
            return definition;
        }

        public static FeatureDefinitionDieRollModifier SetRerollLocalizationKey(this FeatureDefinitionDieRollModifier definition, string value)
        {
            definition.SetField("rerollLocalizationKey", value);
            return definition;
        }

        public static FeatureDefinitionDieRollModifier SetValidityContext(this FeatureDefinitionDieRollModifier definition, RollContext value)
        {
            definition.SetField("validityContext", value);
            return definition;
        }
    }
}