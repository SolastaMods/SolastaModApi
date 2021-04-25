using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionHealingModifierExtensions
    {
        public static void SetAddLevel(this FeatureDefinitionHealingModifier definition, LevelSourceType value)
        {
            definition.SetField("addLevel", value);
        }

        public static void SetAdvantageOnHitDieSpending(this FeatureDefinitionHealingModifier definition, Boolean value)
        {
            definition.SetField("advantageOnHitDieSpending", value);
        }

        public static void SetCannotGainHitPoints(this FeatureDefinitionHealingModifier definition, Boolean value)
        {
            definition.SetField("cannotGainHitPoints", value);
        }

        public static void SetHealingBonusDiceNumber(this FeatureDefinitionHealingModifier definition, Int32 value)
        {
            definition.SetField("healingBonusDiceNumber", value);
        }

        public static void SetHealingBonusDiceType(this FeatureDefinitionHealingModifier definition, DieType value)
        {
            definition.SetField("healingBonusDiceType", value);
        }

        public static void SetHealsSelfWhenCastingHealingSpell(this FeatureDefinitionHealingModifier definition, Boolean value)
        {
            definition.SetField("healsSelfWhenCastingHealingSpell", value);
        }

        public static void SetMaximizeReceivedHealing(this FeatureDefinitionHealingModifier definition, Boolean value)
        {
            definition.SetField("maximizeReceivedHealing", value);
        }

        public static void SetSelfHealingAddLevel(this FeatureDefinitionHealingModifier definition, LevelSourceType value)
        {
            definition.SetField("selfHealingAddLevel", value);
        }

        public static void SetSelfHealingDiceNumber(this FeatureDefinitionHealingModifier definition, Int32 value)
        {
            definition.SetField("selfHealingDiceNumber", value);
        }

        public static void SetSelfHealingDiceType(this FeatureDefinitionHealingModifier definition, DieType value)
        {
            definition.SetField("selfHealingDiceType", value);
        }
    }
}