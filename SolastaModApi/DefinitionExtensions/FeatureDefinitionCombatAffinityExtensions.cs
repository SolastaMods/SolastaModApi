using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionCombatAffinityExtensions
    {
        public static T SetAttackOfOpportunityImmunity<T>(this T definition, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("attackOfOpportunityImmunity", value);
            return definition;
        }

        public static T SetAttackOfOpportunityOnMeAdvantageType<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("attackOfOpportunityOnMeAdvantageType", value);
            return definition;
        }

        public static T SetAttackOnMeAdvantage<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("attackOnMeAdvantage", value);
            return definition;
        }

        public static T SetAttackOnMeCountLimit<T>(this T definition, int value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("attackOnMeCountLimit", value);
            return definition;
        }

        public static T SetAutoCritical<T>(this T definition, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("autoCritical", value);
            return definition;
        }

        public static T SetIgnoreCover<T>(this T definition, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("ignoreCover", value);
            return definition;
        }

        public static T SetIgnoreRangeAdvantage<T>(this T definition, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("ignoreRangeAdvantage", value);
            return definition;
        }

        public static T SetInitiativeAffinity<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("initiativeAffinity", value);
            return definition;
        }

        public static T SetMultiAttackAffinity<T>(this T definition, bool value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("multiAttackAffinity", value);
            return definition;
        }

        public static T SetMultiAttackDefenseValue<T>(this T definition, int value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("multiAttackDefenseValue", value);
            return definition;
        }

        public static T SetMyAttackAdvantage<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("myAttackAdvantage", value);
            return definition;
        }

        public static T SetMyAttackAffinityFilter<T>(this T definition, AttackAffinityFilter value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("myAttackAffinityFilter", value);
            return definition;
        }

        public static T SetMyAttackDamageMultiplier<T>(this T definition, float value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("myAttackDamageMultiplier", value);
            return definition;
        }

        public static T SetMyAttackModifierDiceNumber<T>(this T definition, int value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("myAttackModifierDiceNumber", value);
            return definition;
        }

        public static T SetMyAttackModifierDieType<T>(this T definition, DieType value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("myAttackModifierDieType", value);
            return definition;
        }

        public static T SetMyAttackModifierSign<T>(this T definition, AttackModifierSign value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("myAttackModifierSign", value);
            return definition;
        }

        public static T SetMyAttackModifierValueDetermination<T>(this T definition, CombatAddinityValueDetermination value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("myAttackModifierValueDetermination", value);
            return definition;
        }

        public static T SetNullifiedBySenses<T>(this T definition, List<SenseMode.Type> value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("nullifiedBySenses", value);
            return definition;
        }

        public static T SetRequiredTargetCondition<T>(this T definition, ConditionDefinition value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("requiredTargetCondition", value);
            return definition;
        }

        public static T SetSituationalContext<T>(this T definition, SituationalContext value)
            where T : FeatureDefinitionCombatAffinity
        {
            definition.SetField("situationalContext", value);
            return definition;
        }
    }
}