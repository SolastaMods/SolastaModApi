using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionAdditionalDamageExtensions
    {
        public static T SetAdditionalDamageType<T>(this T definition, AdditionalDamageType value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("additionalDamageType", value);
            return definition;
        }

        public static T SetAddLightSource<T>(this T definition, bool value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("addLightSource", value);
            return definition;
        }

        public static T SetAttackModeOnly<T>(this T definition, bool value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("attackModeOnly", value);
            return definition;
        }

        public static T SetComputeDescription<T>(this T definition, bool value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("computeDescription", value);
            return definition;
        }

        public static T SetConditionOperations<T>(this T definition, List<ConditionOperationDescription> value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("conditionOperations", value);
            return definition;
        }

        public static T SetDamageAdvancement<T>(this T definition, AdditionalDamageAdvancement value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("damageAdvancement", value);
            return definition;
        }

        public static T SetDamageDiceNumber<T>(this T definition, int value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("damageDiceNumber", value);
            return definition;
        }

        public static T SetDamageDieType<T>(this T definition, DieType value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("damageDieType", value);
            return definition;
        }

        public static T SetDamageSaveAffinity<T>(this T definition, EffectSavingThrowType value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("damageSaveAffinity", value);
            return definition;
        }

        public static T SetDamageValueDetermination<T>(this T definition, AdditionalDamageValueDetermination value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("damageValueDetermination", value);
            return definition;
        }

        public static T SetDiceByRankTable<T>(this T definition, List<DiceByRank> value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("diceByRankTable", value);
            return definition;
        }

        public static T SetFamiliesDiceNumber<T>(this T definition, int value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("familiesDiceNumber", value);
            return definition;
        }

        public static T SetFamiliesWithAdditionalDice<T>(this T definition, List<string> value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("familiesWithAdditionalDice", value);
            return definition;
        }

        public static T SetHasSavingThrow<T>(this T definition, bool value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("hasSavingThrow", value);
            return definition;
        }

        public static T SetImpactParticle<T>(this T definition, GameObject value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("impactParticle", value);
            return definition;
        }

        public static T SetLightSourceForm<T>(this T definition, LightSourceForm value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("lightSourceForm", value);
            return definition;
        }

        public static T SetLimitedUsage<T>(this T definition, FeatureLimitedUsage value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("limitedUsage", value);
            return definition;
        }

        public static T SetNotificationTag<T>(this T definition, string value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("notificationTag", value);
            return definition;
        }

        public static T SetRequiredCharacterFamily<T>(this T definition, CharacterFamilyDefinition value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("requiredCharacterFamily", value);
            return definition;
        }

        public static T SetRequiredProperty<T>(this T definition, AdditionalDamageRequiredProperty value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("requiredProperty", value);
            return definition;
        }

        public static T SetRequiredTargetCondition<T>(this T definition, ConditionDefinition value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("requiredTargetCondition", value);
            return definition;
        }

        public static T SetRequiredTargetCreatureTag<T>(this T definition, string value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("requiredTargetCreatureTag", value);
            return definition;
        }

        public static T SetRequiredTargetSenseType<T>(this T definition, SenseMode.Type value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("requiredTargetSenseType", value);
            return definition;
        }

        public static T SetSavingThrowAbility<T>(this T definition, string value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("savingThrowAbility", value);
            return definition;
        }

        public static T SetSavingThrowDC<T>(this T definition, int value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("savingThrowDC", value);
            return definition;
        }

        public static T SetSpecificDamageType<T>(this T definition, string value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("specificDamageType", value);
            return definition;
        }

        public static T SetTriggerCondition<T>(this T definition, AdditionalDamageTriggerCondition value)
            where T : FeatureDefinitionAdditionalDamage
        {
            definition.SetField("triggerCondition", value);
            return definition;
        }
    }
}