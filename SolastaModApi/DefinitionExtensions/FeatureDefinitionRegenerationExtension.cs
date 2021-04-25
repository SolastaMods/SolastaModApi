using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionRegenerationExtensions
    {
        public static void SetBonus(this FeatureDefinitionRegeneration definition, Int32 value)
        {
            definition.SetField("bonus", value);
        }

        public static void SetDiceNumber(this FeatureDefinitionRegeneration definition, Int32 value)
        {
            definition.SetField("diceNumber", value);
        }

        public static void SetDieType(this FeatureDefinitionRegeneration definition, DieType value)
        {
            definition.SetField("dieType", value);
        }

        public static void SetPreventingDamages(this FeatureDefinitionRegeneration definition, List<String> value)
        {
            definition.SetField("preventingDamages", value);
        }

        public static void SetTickNumber(this FeatureDefinitionRegeneration definition, Int32 value)
        {
            definition.SetField("tickNumber", value);
        }

        public static void SetTickType(this FeatureDefinitionRegeneration definition, DurationType value)
        {
            definition.SetField("tickType", value);
        }
    }
}