using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionRegenerationExtensions
    {
        public static FeatureDefinitionRegeneration SetBonus(this FeatureDefinitionRegeneration definition, int value)
        {
            definition.SetField("bonus", value);
            return definition;
        }

        public static FeatureDefinitionRegeneration SetDiceNumber(this FeatureDefinitionRegeneration definition, int value)
        {
            definition.SetField("diceNumber", value);
            return definition;
        }

        public static FeatureDefinitionRegeneration SetDieType(this FeatureDefinitionRegeneration definition, DieType value)
        {
            definition.SetField("dieType", value);
            return definition;
        }

        public static FeatureDefinitionRegeneration SetPreventingDamages(this FeatureDefinitionRegeneration definition, List<string> value)
        {
            definition.SetField("preventingDamages", value);
            return definition;
        }

        public static FeatureDefinitionRegeneration SetTickNumber(this FeatureDefinitionRegeneration definition, int value)
        {
            definition.SetField("tickNumber", value);
            return definition;
        }

        public static FeatureDefinitionRegeneration SetTickType(this FeatureDefinitionRegeneration definition, DurationType value)
        {
            definition.SetField("tickType", value);
            return definition;
        }
    }
}