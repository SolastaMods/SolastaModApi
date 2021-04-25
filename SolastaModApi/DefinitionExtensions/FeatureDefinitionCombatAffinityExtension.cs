using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCombatAffinityExtensions
    {
        public static void SetAttackOfOpportunityImmunity(this FeatureDefinitionCombatAffinity definition, Boolean value)
        {
            definition.SetField("attackOfOpportunityImmunity", value);
        }

        public static void SetAttackOfOpportunityOnMeAdvantageType(this FeatureDefinitionCombatAffinity definition, AdvantageType value)
        {
            definition.SetField("attackOfOpportunityOnMeAdvantageType", value);
        }

        public static void SetAttackOnMeAdvantage(this FeatureDefinitionCombatAffinity definition, AdvantageType value)
        {
            definition.SetField("attackOnMeAdvantage", value);
        }

        public static void SetAttackOnMeCountLimit(this FeatureDefinitionCombatAffinity definition, Int32 value)
        {
            definition.SetField("attackOnMeCountLimit", value);
        }

        public static void SetAutoCritical(this FeatureDefinitionCombatAffinity definition, Boolean value)
        {
            definition.SetField("autoCritical", value);
        }

        public static void SetIgnoreCover(this FeatureDefinitionCombatAffinity definition, Boolean value)
        {
            definition.SetField("ignoreCover", value);
        }

        public static void SetIgnoreRangeAdvantage(this FeatureDefinitionCombatAffinity definition, Boolean value)
        {
            definition.SetField("ignoreRangeAdvantage", value);
        }

        public static void SetInitiativeAffinity(this FeatureDefinitionCombatAffinity definition, AdvantageType value)
        {
            definition.SetField("initiativeAffinity", value);
        }

        public static void SetMultiAttackAffinity(this FeatureDefinitionCombatAffinity definition, Boolean value)
        {
            definition.SetField("multiAttackAffinity", value);
        }

        public static void SetMultiAttackDefenseValue(this FeatureDefinitionCombatAffinity definition, Int32 value)
        {
            definition.SetField("multiAttackDefenseValue", value);
        }

        public static void SetMyAttackAdvantage(this FeatureDefinitionCombatAffinity definition, AdvantageType value)
        {
            definition.SetField("myAttackAdvantage", value);
        }

        public static void SetMyAttackAffinityFilter(this FeatureDefinitionCombatAffinity definition, AttackAffinityFilter value)
        {
            definition.SetField("myAttackAffinityFilter", value);
        }

        public static void SetMyAttackDamageMultiplier(this FeatureDefinitionCombatAffinity definition, Single value)
        {
            definition.SetField("myAttackDamageMultiplier", value);
        }

        public static void SetMyAttackModifierDiceNumber(this FeatureDefinitionCombatAffinity definition, Int32 value)
        {
            definition.SetField("myAttackModifierDiceNumber", value);
        }

        public static void SetMyAttackModifierDieType(this FeatureDefinitionCombatAffinity definition, DieType value)
        {
            definition.SetField("myAttackModifierDieType", value);
        }

        public static void SetMyAttackModifierSign(this FeatureDefinitionCombatAffinity definition, AttackModifierSign value)
        {
            definition.SetField("myAttackModifierSign", value);
        }

        public static void SetMyAttackModifierValueDetermination(this FeatureDefinitionCombatAffinity definition, CombatAddinityValueDetermination value)
        {
            definition.SetField("myAttackModifierValueDetermination", value);
        }

        public static void SetNullifiedBySenses(this FeatureDefinitionCombatAffinity definition, List<SenseMode.Type> value)
        {
            definition.SetField("nullifiedBySenses", value);
        }

        public static void SetRequiredTargetCondition(this FeatureDefinitionCombatAffinity definition, ConditionDefinition value)
        {
            definition.SetField("requiredTargetCondition", value);
        }

        public static void SetSituationalContext(this FeatureDefinitionCombatAffinity definition, SituationalContext value)
        {
            definition.SetField("situationalContext", value);
        }
    }
}