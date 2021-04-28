using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionAttackModifierExtensions
    {
        public static T SetAdditionalAttackTag<T>(this T entity, string value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("additionalAttackTag", value);
            return entity;
        }

        public static T SetAttackRollAbilityScore<T>(this T entity, string value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("attackRollAbilityScore", value);
            return entity;
        }

        public static T SetAttackRollModifier<T>(this T entity, int value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("attackRollModifier", value);
            return entity;
        }

        public static T SetAttackRollModifierMethod<T>(this T entity, AttackModifierMethod value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("attackRollModifierMethod", value);
            return entity;
        }

        public static T SetCanAddAbilityBonusToSecondary<T>(this T entity, bool value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("canAddAbilityBonusToSecondary", value);
            return entity;
        }

        public static T SetCanDualWieldNonLight<T>(this T entity, bool value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("canDualWieldNonLight", value);
            return entity;
        }

        public static T SetDamageRollAbilityScore<T>(this T entity, string value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("damageRollAbilityScore", value);
            return entity;
        }

        public static T SetDamageRollModifier<T>(this T entity, int value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("damageRollModifier", value);
            return entity;
        }

        public static T SetDamageRollModifierMethod<T>(this T entity, AttackModifierMethod value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("damageRollModifierMethod", value);
            return entity;
        }

        public static T SetFollowUpAddAbilityBonus<T>(this T entity, bool value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("followUpAddAbilityBonus", value);
            return entity;
        }

        public static T SetFollowUpDamageDie<T>(this T entity, DieType value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("followUpDamageDie", value);
            return entity;
        }

        public static T SetFollowUpStrike<T>(this T entity, bool value)
            where T : FeatureDefinitionAttackModifier
        {
            entity.SetField("followUpStrike", value);
            return entity;
        }
    }
}