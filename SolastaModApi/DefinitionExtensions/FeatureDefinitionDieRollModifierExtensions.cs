using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionDieRollModifierExtensions
    {
        public static T SetMaxRollValue<T>(this T definition, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            definition.SetField("maxRollValue", value);
            return definition;
        }

        public static T SetMinRerollValue<T>(this T definition, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            definition.SetField("minRerollValue", value);
            return definition;
        }

        public static T SetMinRollValue<T>(this T definition, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            definition.SetField("minRollValue", value);
            return definition;
        }

        public static T SetRerollCount<T>(this T definition, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            definition.SetField("rerollCount", value);
            return definition;
        }

        public static T SetRerollLocalizationKey<T>(this T definition, string value)
            where T : FeatureDefinitionDieRollModifier
        {
            definition.SetField("rerollLocalizationKey", value);
            return definition;
        }

        public static T SetValidityContext<T>(this T definition, RollContext value)
            where T : FeatureDefinitionDieRollModifier
        {
            definition.SetField("validityContext", value);
            return definition;
        }
    }
}