using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionPowerExtensions
    {
        public static void SetAbilityScore(this FeatureDefinitionPower definition, String value)
        {
            definition.SetField("abilityScore", value);
        }

        public static void SetAbilityScoreBonusToAttack(this FeatureDefinitionPower definition, Boolean value)
        {
            definition.SetField("abilityScoreBonusToAttack", value);
        }

        public static void SetActivationTime(this FeatureDefinitionPower definition, ActivationTime value)
        {
            definition.SetField("activationTime", value);
        }

        public static void SetCostPerUse(this FeatureDefinitionPower definition, Int32 value)
        {
            definition.SetField("costPerUse", value);
        }

        public static void SetDelegatedToAction(this FeatureDefinitionPower definition, Boolean value)
        {
            definition.SetField("delegatedToAction", value);
        }

        public static void SetEffectDescription(this FeatureDefinitionPower definition, EffectDescription value)
        {
            definition.SetField("effectDescription", value);
        }

        public static void SetFixedUsesPerRecharge(this FeatureDefinitionPower definition, Int32 value)
        {
            definition.SetField("fixedUsesPerRecharge", value);
        }

        public static void SetProficiencyBonusToAttack(this FeatureDefinitionPower definition, Boolean value)
        {
            definition.SetField("proficiencyBonusToAttack", value);
        }

        public static void SetReactionContext(this FeatureDefinitionPower definition, ReactionTriggerContext value)
        {
            definition.SetField("reactionContext", value);
        }

        public static void SetRechargeRate(this FeatureDefinitionPower definition, RechargeRate value)
        {
            definition.SetField("rechargeRate", value);
        }

        public static void SetShortTitleOverride(this FeatureDefinitionPower definition, String value)
        {
            definition.SetField("shortTitleOverride", value);
        }

        public static void SetShowCasting(this FeatureDefinitionPower definition, Boolean value)
        {
            definition.SetField("showCasting", value);
        }

        public static void SetSpellcastingFeature(this FeatureDefinitionPower definition, FeatureDefinitionCastSpell value)
        {
            definition.SetField("spellcastingFeature", value);
        }

        public static void SetUniqueInstance(this FeatureDefinitionPower definition, Boolean value)
        {
            definition.SetField("uniqueInstance", value);
        }

        public static void SetUsesAbilityScoreName(this FeatureDefinitionPower definition, String value)
        {
            definition.SetField("usesAbilityScoreName", value);
        }

        public static void SetUsesDetermination(this FeatureDefinitionPower definition, UsesDetermination value)
        {
            definition.SetField("usesDetermination", value);
        }
    }
}