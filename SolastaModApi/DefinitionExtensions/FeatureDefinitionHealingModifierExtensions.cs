using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionHealingModifierExtensions
    {
        public static T SetAddLevel<T>(this T definition, LevelSourceType value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("addLevel", value);
            return definition;
        }

        public static T SetAdvantageOnHitDieSpending<T>(this T definition, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("advantageOnHitDieSpending", value);
            return definition;
        }

        public static T SetCannotGainHitPoints<T>(this T definition, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("cannotGainHitPoints", value);
            return definition;
        }

        public static T SetHealingBonusDiceNumber<T>(this T definition, int value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("healingBonusDiceNumber", value);
            return definition;
        }

        public static T SetHealingBonusDiceType<T>(this T definition, DieType value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("healingBonusDiceType", value);
            return definition;
        }

        public static T SetHealsSelfWhenCastingHealingSpell<T>(this T definition, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("healsSelfWhenCastingHealingSpell", value);
            return definition;
        }

        public static T SetMaximizeReceivedHealing<T>(this T definition, bool value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("maximizeReceivedHealing", value);
            return definition;
        }

        public static T SetSelfHealingAddLevel<T>(this T definition, LevelSourceType value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("selfHealingAddLevel", value);
            return definition;
        }

        public static T SetSelfHealingDiceNumber<T>(this T definition, int value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("selfHealingDiceNumber", value);
            return definition;
        }

        public static T SetSelfHealingDiceType<T>(this T definition, DieType value)
            where T : FeatureDefinitionHealingModifier
        {
            definition.SetField("selfHealingDiceType", value);
            return definition;
        }
    }
}