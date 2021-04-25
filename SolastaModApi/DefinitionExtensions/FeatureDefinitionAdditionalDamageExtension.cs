using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAdditionalDamageExtensions
    {
        public static FeatureDefinitionAdditionalDamage SetAdditionalDamageType(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageType value)
        {
            definition.SetField("additionalDamageType", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetAddLightSource(this FeatureDefinitionAdditionalDamage definition, bool value)
        {
            definition.SetField("addLightSource", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetAttackModeOnly(this FeatureDefinitionAdditionalDamage definition, bool value)
        {
            definition.SetField("attackModeOnly", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetComputeDescription(this FeatureDefinitionAdditionalDamage definition, bool value)
        {
            definition.SetField("computeDescription", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetConditionOperations(this FeatureDefinitionAdditionalDamage definition, List<ConditionOperationDescription> value)
        {
            definition.SetField("conditionOperations", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetDamageAdvancement(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageAdvancement value)
        {
            definition.SetField("damageAdvancement", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetDamageDiceNumber(this FeatureDefinitionAdditionalDamage definition, int value)
        {
            definition.SetField("damageDiceNumber", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetDamageDieType(this FeatureDefinitionAdditionalDamage definition, DieType value)
        {
            definition.SetField("damageDieType", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetDamageSaveAffinity(this FeatureDefinitionAdditionalDamage definition, EffectSavingThrowType value)
        {
            definition.SetField("damageSaveAffinity", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetDamageValueDetermination(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageValueDetermination value)
        {
            definition.SetField("damageValueDetermination", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetDiceByRankTable(this FeatureDefinitionAdditionalDamage definition, List<DiceByRank> value)
        {
            definition.SetField("diceByRankTable", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetFamiliesDiceNumber(this FeatureDefinitionAdditionalDamage definition, int value)
        {
            definition.SetField("familiesDiceNumber", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetFamiliesWithAdditionalDice(this FeatureDefinitionAdditionalDamage definition, List<string> value)
        {
            definition.SetField("familiesWithAdditionalDice", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetHasSavingThrow(this FeatureDefinitionAdditionalDamage definition, bool value)
        {
            definition.SetField("hasSavingThrow", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetImpactParticle(this FeatureDefinitionAdditionalDamage definition, GameObject value)
        {
            definition.SetField("impactParticle", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetLightSourceForm(this FeatureDefinitionAdditionalDamage definition, LightSourceForm value)
        {
            definition.SetField("lightSourceForm", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetLimitedUsage(this FeatureDefinitionAdditionalDamage definition, FeatureLimitedUsage value)
        {
            definition.SetField("limitedUsage", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetNotificationTag(this FeatureDefinitionAdditionalDamage definition, string value)
        {
            definition.SetField("notificationTag", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetRequiredCharacterFamily(this FeatureDefinitionAdditionalDamage definition, CharacterFamilyDefinition value)
        {
            definition.SetField("requiredCharacterFamily", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetRequiredProperty(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageRequiredProperty value)
        {
            definition.SetField("requiredProperty", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetRequiredTargetCondition(this FeatureDefinitionAdditionalDamage definition, ConditionDefinition value)
        {
            definition.SetField("requiredTargetCondition", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetRequiredTargetCreatureTag(this FeatureDefinitionAdditionalDamage definition, string value)
        {
            definition.SetField("requiredTargetCreatureTag", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetRequiredTargetSenseType(this FeatureDefinitionAdditionalDamage definition, SenseMode.Type value)
        {
            definition.SetField("requiredTargetSenseType", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetSavingThrowAbility(this FeatureDefinitionAdditionalDamage definition, string value)
        {
            definition.SetField("savingThrowAbility", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetSavingThrowDC(this FeatureDefinitionAdditionalDamage definition, int value)
        {
            definition.SetField("savingThrowDC", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetSpecificDamageType(this FeatureDefinitionAdditionalDamage definition, string value)
        {
            definition.SetField("specificDamageType", value);
            return definition;
        }

        public static FeatureDefinitionAdditionalDamage SetTriggerCondition(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageTriggerCondition value)
        {
            definition.SetField("triggerCondition", value);
            return definition;
        }
    }
}