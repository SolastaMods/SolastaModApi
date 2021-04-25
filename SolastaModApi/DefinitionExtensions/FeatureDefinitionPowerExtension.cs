using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionPowerExtensions
    {
        public static FeatureDefinitionPower SetAbilityScore(this FeatureDefinitionPower definition, string value)
        {
            definition.SetField("abilityScore", value);
            return definition;
        }

        public static FeatureDefinitionPower SetAbilityScoreBonusToAttack(this FeatureDefinitionPower definition, bool value)
        {
            definition.SetField("abilityScoreBonusToAttack", value);
            return definition;
        }

        public static FeatureDefinitionPower SetActivationTime(this FeatureDefinitionPower definition, ActivationTime value)
        {
            definition.SetField("activationTime", value);
            return definition;
        }

        public static FeatureDefinitionPower SetCostPerUse(this FeatureDefinitionPower definition, int value)
        {
            definition.SetField("costPerUse", value);
            return definition;
        }

        public static FeatureDefinitionPower SetDelegatedToAction(this FeatureDefinitionPower definition, bool value)
        {
            definition.SetField("delegatedToAction", value);
            return definition;
        }

        public static FeatureDefinitionPower SetEffectDescription(this FeatureDefinitionPower definition, EffectDescription value)
        {
            definition.SetField("effectDescription", value);
            return definition;
        }

        public static FeatureDefinitionPower SetFixedUsesPerRecharge(this FeatureDefinitionPower definition, int value)
        {
            definition.SetField("fixedUsesPerRecharge", value);
            return definition;
        }

        public static FeatureDefinitionPower SetProficiencyBonusToAttack(this FeatureDefinitionPower definition, bool value)
        {
            definition.SetField("proficiencyBonusToAttack", value);
            return definition;
        }

        public static FeatureDefinitionPower SetReactionContext(this FeatureDefinitionPower definition, ReactionTriggerContext value)
        {
            definition.SetField("reactionContext", value);
            return definition;
        }

        public static FeatureDefinitionPower SetRechargeRate(this FeatureDefinitionPower definition, RechargeRate value)
        {
            definition.SetField("rechargeRate", value);
            return definition;
        }

        public static FeatureDefinitionPower SetShortTitleOverride(this FeatureDefinitionPower definition, string value)
        {
            definition.SetField("shortTitleOverride", value);
            return definition;
        }

        public static FeatureDefinitionPower SetShowCasting(this FeatureDefinitionPower definition, bool value)
        {
            definition.SetField("showCasting", value);
            return definition;
        }

        public static FeatureDefinitionPower SetSpellcastingFeature(this FeatureDefinitionPower definition, FeatureDefinitionCastSpell value)
        {
            definition.SetField("spellcastingFeature", value);
            return definition;
        }

        public static FeatureDefinitionPower SetUniqueInstance(this FeatureDefinitionPower definition, bool value)
        {
            definition.SetField("uniqueInstance", value);
            return definition;
        }

        public static FeatureDefinitionPower SetUsesAbilityScoreName(this FeatureDefinitionPower definition, string value)
        {
            definition.SetField("usesAbilityScoreName", value);
            return definition;
        }

        public static FeatureDefinitionPower SetUsesDetermination(this FeatureDefinitionPower definition, UsesDetermination value)
        {
            definition.SetField("usesDetermination", value);
            return definition;
        }
    }
}