using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCombatAffinityExtensions
    {
        public static FeatureDefinitionCombatAffinity SetAttackOfOpportunityImmunity(this FeatureDefinitionCombatAffinity definition, bool value)
        {
            definition.SetField("attackOfOpportunityImmunity", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetAttackOfOpportunityOnMeAdvantageType(this FeatureDefinitionCombatAffinity definition, AdvantageType value)
        {
            definition.SetField("attackOfOpportunityOnMeAdvantageType", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetAttackOnMeAdvantage(this FeatureDefinitionCombatAffinity definition, AdvantageType value)
        {
            definition.SetField("attackOnMeAdvantage", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetAttackOnMeCountLimit(this FeatureDefinitionCombatAffinity definition, int value)
        {
            definition.SetField("attackOnMeCountLimit", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetAutoCritical(this FeatureDefinitionCombatAffinity definition, bool value)
        {
            definition.SetField("autoCritical", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetIgnoreCover(this FeatureDefinitionCombatAffinity definition, bool value)
        {
            definition.SetField("ignoreCover", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetIgnoreRangeAdvantage(this FeatureDefinitionCombatAffinity definition, bool value)
        {
            definition.SetField("ignoreRangeAdvantage", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetInitiativeAffinity(this FeatureDefinitionCombatAffinity definition, AdvantageType value)
        {
            definition.SetField("initiativeAffinity", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMultiAttackAffinity(this FeatureDefinitionCombatAffinity definition, bool value)
        {
            definition.SetField("multiAttackAffinity", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMultiAttackDefenseValue(this FeatureDefinitionCombatAffinity definition, int value)
        {
            definition.SetField("multiAttackDefenseValue", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMyAttackAdvantage(this FeatureDefinitionCombatAffinity definition, AdvantageType value)
        {
            definition.SetField("myAttackAdvantage", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMyAttackAffinityFilter(this FeatureDefinitionCombatAffinity definition, AttackAffinityFilter value)
        {
            definition.SetField("myAttackAffinityFilter", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMyAttackDamageMultiplier(this FeatureDefinitionCombatAffinity definition, float value)
        {
            definition.SetField("myAttackDamageMultiplier", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMyAttackModifierDiceNumber(this FeatureDefinitionCombatAffinity definition, int value)
        {
            definition.SetField("myAttackModifierDiceNumber", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMyAttackModifierDieType(this FeatureDefinitionCombatAffinity definition, DieType value)
        {
            definition.SetField("myAttackModifierDieType", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMyAttackModifierSign(this FeatureDefinitionCombatAffinity definition, AttackModifierSign value)
        {
            definition.SetField("myAttackModifierSign", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetMyAttackModifierValueDetermination(this FeatureDefinitionCombatAffinity definition, CombatAddinityValueDetermination value)
        {
            definition.SetField("myAttackModifierValueDetermination", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetNullifiedBySenses(this FeatureDefinitionCombatAffinity definition, List<SenseMode.Type> value)
        {
            definition.SetField("nullifiedBySenses", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetRequiredTargetCondition(this FeatureDefinitionCombatAffinity definition, ConditionDefinition value)
        {
            definition.SetField("requiredTargetCondition", value);
            return definition;
        }

        public static FeatureDefinitionCombatAffinity SetSituationalContext(this FeatureDefinitionCombatAffinity definition, SituationalContext value)
        {
            definition.SetField("situationalContext", value);
            return definition;
        }
    }
}