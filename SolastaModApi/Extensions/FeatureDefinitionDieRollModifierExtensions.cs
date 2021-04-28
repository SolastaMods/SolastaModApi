using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionDieRollModifierExtensions
    {
        public static T SetMaxRollValue<T>(this T entity, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("maxRollValue", value);
            return entity;
        }

        public static T SetMinRerollValue<T>(this T entity, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("minRerollValue", value);
            return entity;
        }

        public static T SetMinRollValue<T>(this T entity, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("minRollValue", value);
            return entity;
        }

        public static T SetRerollCount<T>(this T entity, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("rerollCount", value);
            return entity;
        }

        public static T SetRerollLocalizationKey<T>(this T entity, string value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("rerollLocalizationKey", value);
            return entity;
        }

        public static T SetValidityContext<T>(this T entity, RollContext value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("validityContext", value);
            return entity;
        }
    }
}