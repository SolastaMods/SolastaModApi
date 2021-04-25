using SolastaModApi.Infrastructure;
using UnityEngine;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAdditionalDamageExtensions
    {
        public static void SetAdditionalDamageType(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageType value)
        {
            definition.SetField("additionalDamageType", value);
        }

        public static void SetAddLightSource(this FeatureDefinitionAdditionalDamage definition, Boolean value)
        {
            definition.SetField("addLightSource", value);
        }

        public static void SetAttackModeOnly(this FeatureDefinitionAdditionalDamage definition, Boolean value)
        {
            definition.SetField("attackModeOnly", value);
        }

        public static void SetComputeDescription(this FeatureDefinitionAdditionalDamage definition, Boolean value)
        {
            definition.SetField("computeDescription", value);
        }

        public static void SetConditionOperations(this FeatureDefinitionAdditionalDamage definition, List<ConditionOperationDescription> value)
        {
            definition.SetField("conditionOperations", value);
        }

        public static void SetDamageAdvancement(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageAdvancement value)
        {
            definition.SetField("damageAdvancement", value);
        }

        public static void SetDamageDiceNumber(this FeatureDefinitionAdditionalDamage definition, Int32 value)
        {
            definition.SetField("damageDiceNumber", value);
        }

        public static void SetDamageDieType(this FeatureDefinitionAdditionalDamage definition, DieType value)
        {
            definition.SetField("damageDieType", value);
        }

        public static void SetDamageSaveAffinity(this FeatureDefinitionAdditionalDamage definition, EffectSavingThrowType value)
        {
            definition.SetField("damageSaveAffinity", value);
        }

        public static void SetDamageValueDetermination(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageValueDetermination value)
        {
            definition.SetField("damageValueDetermination", value);
        }

        public static void SetDiceByRankTable(this FeatureDefinitionAdditionalDamage definition, List<DiceByRank> value)
        {
            definition.SetField("diceByRankTable", value);
        }

        public static void SetFamiliesDiceNumber(this FeatureDefinitionAdditionalDamage definition, Int32 value)
        {
            definition.SetField("familiesDiceNumber", value);
        }

        public static void SetFamiliesWithAdditionalDice(this FeatureDefinitionAdditionalDamage definition, List<String> value)
        {
            definition.SetField("familiesWithAdditionalDice", value);
        }

        public static void SetHasSavingThrow(this FeatureDefinitionAdditionalDamage definition, Boolean value)
        {
            definition.SetField("hasSavingThrow", value);
        }

        public static void SetImpactParticle(this FeatureDefinitionAdditionalDamage definition, GameObject value)
        {
            definition.SetField("impactParticle", value);
        }

        public static void SetLightSourceForm(this FeatureDefinitionAdditionalDamage definition, LightSourceForm value)
        {
            definition.SetField("lightSourceForm", value);
        }

        public static void SetLimitedUsage(this FeatureDefinitionAdditionalDamage definition, FeatureLimitedUsage value)
        {
            definition.SetField("limitedUsage", value);
        }

        public static void SetNotificationTag(this FeatureDefinitionAdditionalDamage definition, String value)
        {
            definition.SetField("notificationTag", value);
        }

        public static void SetRequiredCharacterFamily(this FeatureDefinitionAdditionalDamage definition, CharacterFamilyDefinition value)
        {
            definition.SetField("requiredCharacterFamily", value);
        }

        public static void SetRequiredProperty(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageRequiredProperty value)
        {
            definition.SetField("requiredProperty", value);
        }

        public static void SetRequiredTargetCondition(this FeatureDefinitionAdditionalDamage definition, ConditionDefinition value)
        {
            definition.SetField("requiredTargetCondition", value);
        }

        public static void SetRequiredTargetCreatureTag(this FeatureDefinitionAdditionalDamage definition, String value)
        {
            definition.SetField("requiredTargetCreatureTag", value);
        }

        public static void SetRequiredTargetSenseType(this FeatureDefinitionAdditionalDamage definition, SenseMode.Type value)
        {
            definition.SetField("requiredTargetSenseType", value);
        }

        public static void SetSavingThrowAbility(this FeatureDefinitionAdditionalDamage definition, String value)
        {
            definition.SetField("savingThrowAbility", value);
        }

        public static void SetSavingThrowDC(this FeatureDefinitionAdditionalDamage definition, Int32 value)
        {
            definition.SetField("savingThrowDC", value);
        }

        public static void SetSpecificDamageType(this FeatureDefinitionAdditionalDamage definition, String value)
        {
            definition.SetField("specificDamageType", value);
        }

        public static void SetTriggerCondition(this FeatureDefinitionAdditionalDamage definition, AdditionalDamageTriggerCondition value)
        {
            definition.SetField("triggerCondition", value);
        }
    }
}