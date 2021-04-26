using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionPowerExtensions
    {
        public static T SetAbilityScore<T>(this T definition, string value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("abilityScore", value);
            return definition;
        }

        public static T SetAbilityScoreBonusToAttack<T>(this T definition, bool value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("abilityScoreBonusToAttack", value);
            return definition;
        }

        public static T SetActivationTime<T>(this T definition, ActivationTime value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("activationTime", value);
            return definition;
        }

        public static T SetCostPerUse<T>(this T definition, int value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("costPerUse", value);
            return definition;
        }

        public static T SetDelegatedToAction<T>(this T definition, bool value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("delegatedToAction", value);
            return definition;
        }

        public static T SetEffectDescription<T>(this T definition, EffectDescription value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("effectDescription", value);
            return definition;
        }

        public static T SetFixedUsesPerRecharge<T>(this T definition, int value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("fixedUsesPerRecharge", value);
            return definition;
        }

        public static T SetProficiencyBonusToAttack<T>(this T definition, bool value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("proficiencyBonusToAttack", value);
            return definition;
        }

        public static T SetReactionContext<T>(this T definition, ReactionTriggerContext value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("reactionContext", value);
            return definition;
        }

        public static T SetRechargeRate<T>(this T definition, RechargeRate value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("rechargeRate", value);
            return definition;
        }

        public static T SetShortTitleOverride<T>(this T definition, string value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("shortTitleOverride", value);
            return definition;
        }

        public static T SetShowCasting<T>(this T definition, bool value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("showCasting", value);
            return definition;
        }

        public static T SetSpellcastingFeature<T>(this T definition, FeatureDefinitionCastSpell value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("spellcastingFeature", value);
            return definition;
        }

        public static T SetUniqueInstance<T>(this T definition, bool value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("uniqueInstance", value);
            return definition;
        }

        public static T SetUsesAbilityScoreName<T>(this T definition, string value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("usesAbilityScoreName", value);
            return definition;
        }

        public static T SetUsesDetermination<T>(this T definition, UsesDetermination value)
            where T : FeatureDefinitionPower
        {
            definition.SetField("usesDetermination", value);
            return definition;
        }
    }
}