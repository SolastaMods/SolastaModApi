using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAttackModifierExtensions
    {
        public static FeatureDefinitionAttackModifier SetAdditionalAttackTag(this FeatureDefinitionAttackModifier definition, string value)
        {
            definition.SetField("additionalAttackTag", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetAttackRollAbilityScore(this FeatureDefinitionAttackModifier definition, string value)
        {
            definition.SetField("attackRollAbilityScore", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetAttackRollModifier(this FeatureDefinitionAttackModifier definition, int value)
        {
            definition.SetField("attackRollModifier", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetAttackRollModifierMethod(this FeatureDefinitionAttackModifier definition, AttackModifierMethod value)
        {
            definition.SetField("attackRollModifierMethod", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetCanAddAbilityBonusToSecondary(this FeatureDefinitionAttackModifier definition, bool value)
        {
            definition.SetField("canAddAbilityBonusToSecondary", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetCanDualWieldNonLight(this FeatureDefinitionAttackModifier definition, bool value)
        {
            definition.SetField("canDualWieldNonLight", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetDamageRollAbilityScore(this FeatureDefinitionAttackModifier definition, string value)
        {
            definition.SetField("damageRollAbilityScore", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetDamageRollModifier(this FeatureDefinitionAttackModifier definition, int value)
        {
            definition.SetField("damageRollModifier", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetDamageRollModifierMethod(this FeatureDefinitionAttackModifier definition, AttackModifierMethod value)
        {
            definition.SetField("damageRollModifierMethod", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetFollowUpAddAbilityBonus(this FeatureDefinitionAttackModifier definition, bool value)
        {
            definition.SetField("followUpAddAbilityBonus", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetFollowUpDamageDie(this FeatureDefinitionAttackModifier definition, DieType value)
        {
            definition.SetField("followUpDamageDie", value);
            return definition;
        }

        public static FeatureDefinitionAttackModifier SetFollowUpStrike(this FeatureDefinitionAttackModifier definition, bool value)
        {
            definition.SetField("followUpStrike", value);
            return definition;
        }
    }
}