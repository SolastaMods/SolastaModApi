using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionRegenerationExtensions
    {
        public static T SetBonus<T>(this T definition, int value)
            where T : FeatureDefinitionRegeneration
        {
            definition.SetField("bonus", value);
            return definition;
        }

        public static T SetDiceNumber<T>(this T definition, int value)
            where T : FeatureDefinitionRegeneration
        {
            definition.SetField("diceNumber", value);
            return definition;
        }

        public static T SetDieType<T>(this T definition, DieType value)
            where T : FeatureDefinitionRegeneration
        {
            definition.SetField("dieType", value);
            return definition;
        }

        public static T SetPreventingDamages<T>(this T definition, List<string> value)
            where T : FeatureDefinitionRegeneration
        {
            definition.SetField("preventingDamages", value);
            return definition;
        }

        public static T SetTickNumber<T>(this T definition, int value)
            where T : FeatureDefinitionRegeneration
        {
            definition.SetField("tickNumber", value);
            return definition;
        }

        public static T SetTickType<T>(this T definition, DurationType value)
            where T : FeatureDefinitionRegeneration
        {
            definition.SetField("tickType", value);
            return definition;
        }
    }
}