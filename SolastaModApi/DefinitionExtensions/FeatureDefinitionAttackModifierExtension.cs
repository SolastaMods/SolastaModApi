using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAttackModifierExtensions
    {
        public static void SetAdditionalAttackTag(this FeatureDefinitionAttackModifier definition, String value)
        {
            definition.SetField("additionalAttackTag", value);
        }

        public static void SetAttackRollAbilityScore(this FeatureDefinitionAttackModifier definition, String value)
        {
            definition.SetField("attackRollAbilityScore", value);
        }

        public static void SetAttackRollModifier(this FeatureDefinitionAttackModifier definition, Int32 value)
        {
            definition.SetField("attackRollModifier", value);
        }

        public static void SetAttackRollModifierMethod(this FeatureDefinitionAttackModifier definition, AttackModifierMethod value)
        {
            definition.SetField("attackRollModifierMethod", value);
        }

        public static void SetCanAddAbilityBonusToSecondary(this FeatureDefinitionAttackModifier definition, Boolean value)
        {
            definition.SetField("canAddAbilityBonusToSecondary", value);
        }

        public static void SetCanDualWieldNonLight(this FeatureDefinitionAttackModifier definition, Boolean value)
        {
            definition.SetField("canDualWieldNonLight", value);
        }

        public static void SetDamageRollAbilityScore(this FeatureDefinitionAttackModifier definition, String value)
        {
            definition.SetField("damageRollAbilityScore", value);
        }

        public static void SetDamageRollModifier(this FeatureDefinitionAttackModifier definition, Int32 value)
        {
            definition.SetField("damageRollModifier", value);
        }

        public static void SetDamageRollModifierMethod(this FeatureDefinitionAttackModifier definition, AttackModifierMethod value)
        {
            definition.SetField("damageRollModifierMethod", value);
        }

        public static void SetFollowUpAddAbilityBonus(this FeatureDefinitionAttackModifier definition, Boolean value)
        {
            definition.SetField("followUpAddAbilityBonus", value);
        }

        public static void SetFollowUpDamageDie(this FeatureDefinitionAttackModifier definition, DieType value)
        {
            definition.SetField("followUpDamageDie", value);
        }

        public static void SetFollowUpStrike(this FeatureDefinitionAttackModifier definition, Boolean value)
        {
            definition.SetField("followUpStrike", value);
        }
    }
}