using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionAttackModifierExtensions
    {
        public static T SetAdditionalAttackTag<T>(this T definition, string value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("additionalAttackTag", value);
            return definition;
        }

        public static T SetAttackRollAbilityScore<T>(this T definition, string value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("attackRollAbilityScore", value);
            return definition;
        }

        public static T SetAttackRollModifier<T>(this T definition, int value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("attackRollModifier", value);
            return definition;
        }

        public static T SetAttackRollModifierMethod<T>(this T definition, AttackModifierMethod value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("attackRollModifierMethod", value);
            return definition;
        }

        public static T SetCanAddAbilityBonusToSecondary<T>(this T definition, bool value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("canAddAbilityBonusToSecondary", value);
            return definition;
        }

        public static T SetCanDualWieldNonLight<T>(this T definition, bool value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("canDualWieldNonLight", value);
            return definition;
        }

        public static T SetDamageRollAbilityScore<T>(this T definition, string value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("damageRollAbilityScore", value);
            return definition;
        }

        public static T SetDamageRollModifier<T>(this T definition, int value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("damageRollModifier", value);
            return definition;
        }

        public static T SetDamageRollModifierMethod<T>(this T definition, AttackModifierMethod value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("damageRollModifierMethod", value);
            return definition;
        }

        public static T SetFollowUpAddAbilityBonus<T>(this T definition, bool value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("followUpAddAbilityBonus", value);
            return definition;
        }

        public static T SetFollowUpDamageDie<T>(this T definition, DieType value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("followUpDamageDie", value);
            return definition;
        }

        public static T SetFollowUpStrike<T>(this T definition, bool value)
            where T : FeatureDefinitionAttackModifier
        {
            definition.SetField("followUpStrike", value);
            return definition;
        }
    }
}