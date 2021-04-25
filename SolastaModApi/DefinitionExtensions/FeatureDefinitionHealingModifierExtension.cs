using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionHealingModifierExtensions
    {
        public static FeatureDefinitionHealingModifier SetAddLevel(this FeatureDefinitionHealingModifier definition, LevelSourceType value)
        {
            definition.SetField("addLevel", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetAdvantageOnHitDieSpending(this FeatureDefinitionHealingModifier definition, bool value)
        {
            definition.SetField("advantageOnHitDieSpending", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetCannotGainHitPoints(this FeatureDefinitionHealingModifier definition, bool value)
        {
            definition.SetField("cannotGainHitPoints", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetHealingBonusDiceNumber(this FeatureDefinitionHealingModifier definition, int value)
        {
            definition.SetField("healingBonusDiceNumber", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetHealingBonusDiceType(this FeatureDefinitionHealingModifier definition, DieType value)
        {
            definition.SetField("healingBonusDiceType", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetHealsSelfWhenCastingHealingSpell(this FeatureDefinitionHealingModifier definition, bool value)
        {
            definition.SetField("healsSelfWhenCastingHealingSpell", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetMaximizeReceivedHealing(this FeatureDefinitionHealingModifier definition, bool value)
        {
            definition.SetField("maximizeReceivedHealing", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetSelfHealingAddLevel(this FeatureDefinitionHealingModifier definition, LevelSourceType value)
        {
            definition.SetField("selfHealingAddLevel", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetSelfHealingDiceNumber(this FeatureDefinitionHealingModifier definition, int value)
        {
            definition.SetField("selfHealingDiceNumber", value);
            return definition;
        }

        public static FeatureDefinitionHealingModifier SetSelfHealingDiceType(this FeatureDefinitionHealingModifier definition, DieType value)
        {
            definition.SetField("selfHealingDiceType", value);
            return definition;
        }
    }
}