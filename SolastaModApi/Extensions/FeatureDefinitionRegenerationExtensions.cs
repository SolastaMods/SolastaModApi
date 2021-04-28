using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionRegenerationExtensions
    {
        public static T SetBonus<T>(this T entity, int value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("bonus", value);
            return entity;
        }

        public static T SetDiceNumber<T>(this T entity, int value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("diceNumber", value);
            return entity;
        }

        public static T SetDieType<T>(this T entity, DieType value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("dieType", value);
            return entity;
        }

        public static T SetTickNumber<T>(this T entity, int value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("tickNumber", value);
            return entity;
        }

        public static T SetTickType<T>(this T entity, DurationType value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("tickType", value);
            return entity;
        }
    }
}