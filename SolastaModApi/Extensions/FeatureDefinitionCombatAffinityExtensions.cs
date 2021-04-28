using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionCombatAffinityExtensions
    {
        public static T SetAttackOfOpportunityImmunity<T>(this T entity, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("attackOfOpportunityImmunity", value);
            return entity;
        }

        public static T SetAttackOfOpportunityOnMeAdvantageType<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("attackOfOpportunityOnMeAdvantageType", value);
            return entity;
        }

        public static T SetAttackOnMeAdvantage<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("attackOnMeAdvantage", value);
            return entity;
        }

        public static T SetAttackOnMeCountLimit<T>(this T entity, int value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("attackOnMeCountLimit", value);
            return entity;
        }

        public static T SetAutoCritical<T>(this T entity, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("autoCritical", value);
            return entity;
        }

        public static T SetIgnoreCover<T>(this T entity, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("ignoreCover", value);
            return entity;
        }

        public static T SetIgnoreRangeAdvantage<T>(this T entity, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("ignoreRangeAdvantage", value);
            return entity;
        }

        public static T SetInitiativeAffinity<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("initiativeAffinity", value);
            return entity;
        }

        public static T SetMultiAttackAffinity<T>(this T entity, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("multiAttackAffinity", value);
            return entity;
        }

        public static T SetMultiAttackDefenseValue<T>(this T entity, int value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("multiAttackDefenseValue", value);
            return entity;
        }

        public static T SetMyAttackAdvantage<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("myAttackAdvantage", value);
            return entity;
        }

        public static T SetMyAttackAffinityFilter<T>(this T entity, AttackAffinityFilter value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("myAttackAffinityFilter", value);
            return entity;
        }

        public static T SetMyAttackDamageMultiplier<T>(this T entity, float value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("myAttackDamageMultiplier", value);
            return entity;
        }

        public static T SetMyAttackModifierDiceNumber<T>(this T entity, int value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("myAttackModifierDiceNumber", value);
            return entity;
        }

        public static T SetMyAttackModifierDieType<T>(this T entity, DieType value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("myAttackModifierDieType", value);
            return entity;
        }

        public static T SetMyAttackModifierSign<T>(this T entity, AttackModifierSign value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("myAttackModifierSign", value);
            return entity;
        }

        public static T SetMyAttackModifierValueDetermination<T>(this T entity, CombatAddinityValueDetermination value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("myAttackModifierValueDetermination", value);
            return entity;
        }

        public static T SetRequiredTargetCondition<T>(this T entity, ConditionDefinition value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("requiredTargetCondition", value);
            return entity;
        }

        public static T SetSituationalContext<T>(this T entity, SituationalContext value)
            where T : FeatureDefinitionCombatAffinity
        {
            entity.SetField("situationalContext", value);
            return entity;
        }
    }
}