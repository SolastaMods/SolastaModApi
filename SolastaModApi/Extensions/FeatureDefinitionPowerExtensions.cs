using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionPowerExtensions
    {
        public static T SetAbilityScore<T>(this T entity, string value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("abilityScore", value);
            return entity;
        }

        public static T SetAbilityScoreBonusToAttack<T>(this T entity, bool value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("abilityScoreBonusToAttack", value);
            return entity;
        }

        public static T SetActivationTime<T>(this T entity, ActivationTime value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("activationTime", value);
            return entity;
        }

        public static T SetCostPerUse<T>(this T entity, int value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("costPerUse", value);
            return entity;
        }

        public static T SetDelegatedToAction<T>(this T entity, bool value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("delegatedToAction", value);
            return entity;
        }

        public static T SetEffectDescription<T>(this T entity, EffectDescription value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("effectDescription", value);
            return entity;
        }

        public static T SetFixedUsesPerRecharge<T>(this T entity, int value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("fixedUsesPerRecharge", value);
            return entity;
        }

        public static T SetProficiencyBonusToAttack<T>(this T entity, bool value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("proficiencyBonusToAttack", value);
            return entity;
        }

        public static T SetReactionContext<T>(this T entity, ReactionTriggerContext value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("reactionContext", value);
            return entity;
        }

        public static T SetRechargeRate<T>(this T entity, RechargeRate value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("rechargeRate", value);
            return entity;
        }

        public static T SetShortTitleOverride<T>(this T entity, string value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("shortTitleOverride", value);
            return entity;
        }

        public static T SetShowCasting<T>(this T entity, bool value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("showCasting", value);
            return entity;
        }

        public static T SetSpellcastingFeature<T>(this T entity, FeatureDefinitionCastSpell value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("spellcastingFeature", value);
            return entity;
        }

        public static T SetUniqueInstance<T>(this T entity, bool value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("uniqueInstance", value);
            return entity;
        }

        public static T SetUsesAbilityScoreName<T>(this T entity, string value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("usesAbilityScoreName", value);
            return entity;
        }

        public static T SetUsesDetermination<T>(this T entity, UsesDetermination value)
            where T : FeatureDefinitionPower
        {
            entity.SetField("usesDetermination", value);
            return entity;
        }
    }
}