using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionAdditionalDamageExtensions
    {
        public static T SetAdditionalDamageType<T>(this T entity, AdditionalDamageType value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("additionalDamageType", value);
            return entity;
        }

        public static T SetAddLightSource<T>(this T entity, bool value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("addLightSource", value);
            return entity;
        }

        public static T SetAttackModeOnly<T>(this T entity, bool value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("attackModeOnly", value);
            return entity;
        }

        public static T SetComputeDescription<T>(this T entity, bool value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("computeDescription", value);
            return entity;
        }

        public static T SetDamageAdvancement<T>(this T entity, AdditionalDamageAdvancement value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("damageAdvancement", value);
            return entity;
        }

        public static T SetDamageDiceNumber<T>(this T entity, int value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("damageDiceNumber", value);
            return entity;
        }

        public static T SetDamageDieType<T>(this T entity, DieType value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("damageDieType", value);
            return entity;
        }

        public static T SetDamageSaveAffinity<T>(this T entity, EffectSavingThrowType value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("damageSaveAffinity", value);
            return entity;
        }

        public static T SetDamageValueDetermination<T>(this T entity, AdditionalDamageValueDetermination value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("damageValueDetermination", value);
            return entity;
        }

        public static T SetFamiliesDiceNumber<T>(this T entity, int value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("familiesDiceNumber", value);
            return entity;
        }

        public static T SetHasSavingThrow<T>(this T entity, bool value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("hasSavingThrow", value);
            return entity;
        }

        public static T SetImpactParticle<T>(this T entity, GameObject value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("impactParticle", value);
            return entity;
        }

        public static T SetLightSourceForm<T>(this T entity, LightSourceForm value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("lightSourceForm", value);
            return entity;
        }

        public static T SetLimitedUsage<T>(this T entity, FeatureLimitedUsage value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("limitedUsage", value);
            return entity;
        }

        public static T SetNotificationTag<T>(this T entity, string value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("notificationTag", value);
            return entity;
        }

        public static T SetRequiredCharacterFamily<T>(this T entity, CharacterFamilyDefinition value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("requiredCharacterFamily", value);
            return entity;
        }

        public static T SetRequiredProperty<T>(this T entity, AdditionalDamageRequiredProperty value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("requiredProperty", value);
            return entity;
        }

        public static T SetRequiredTargetCondition<T>(this T entity, ConditionDefinition value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("requiredTargetCondition", value);
            return entity;
        }

        public static T SetRequiredTargetCreatureTag<T>(this T entity, string value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("requiredTargetCreatureTag", value);
            return entity;
        }

        public static T SetRequiredTargetSenseType<T>(this T entity, SenseMode.Type value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("requiredTargetSenseType", value);
            return entity;
        }

        public static T SetSavingThrowAbility<T>(this T entity, string value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("savingThrowAbility", value);
            return entity;
        }

        public static T SetSavingThrowDC<T>(this T entity, int value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("savingThrowDC", value);
            return entity;
        }

        public static T SetSpecificDamageType<T>(this T entity, string value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("specificDamageType", value);
            return entity;
        }

        public static T SetTriggerCondition<T>(this T entity, AdditionalDamageTriggerCondition value)
            where T : FeatureDefinitionAdditionalDamage
        {
            entity.SetField("triggerCondition", value);
            return entity;
        }
    }
}