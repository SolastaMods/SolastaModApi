using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class ConditionDefinitionExtensions
    {
        public static T SetAdditionalCondition<T>(this T entity, ConditionDefinition value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalCondition", value);
            return entity;
        }

        public static T SetAdditionalConditionDurationParameter<T>(this T entity, int value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalConditionDurationParameter", value);
            return entity;
        }

        public static T SetAdditionalConditionDurationType<T>(this T entity, DurationType value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalConditionDurationType", value);
            return entity;
        }

        public static T SetAdditionalConditionWhenHit<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalConditionWhenHit", value);
            return entity;
        }

        public static T SetAdditionalDamageDieNumber<T>(this T entity, int value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalDamageDieNumber", value);
            return entity;
        }

        public static T SetAdditionalDamageDieType<T>(this T entity, DieType value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalDamageDieType", value);
            return entity;
        }

        public static T SetAdditionalDamageQuantity<T>(this T entity, ConditionDefinition.DamageQuantity value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalDamageQuantity", value);
            return entity;
        }

        public static T SetAdditionalDamageType<T>(this T entity, string value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalDamageType", value);
            return entity;
        }

        public static T SetAdditionalDamageWhenHit<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("additionalDamageWhenHit", value);
            return entity;
        }

        public static T SetAdditiveAmount<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("additiveAmount", value);
            return entity;
        }

        public static T SetAllowMultipleInstances<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("allowMultipleInstances", value);
            return entity;
        }

        public static T SetAmountOrigin<T>(this T entity, ConditionDefinition.OriginOfAmount value)
            where T : ConditionDefinition
        {
            entity.SetField("amountOrigin", value);
            return entity;
        }

        public static T SetBaseAmount<T>(this T entity, int value)
            where T : ConditionDefinition
        {
            entity.SetField("baseAmount", value);
            return entity;
        }

        public static T SetBattlePackage<T>(this T entity, DecisionPackageDefinition value)
            where T : ConditionDefinition
        {
            entity.SetField("battlePackage", value);
            return entity;
        }

        public static T SetCharacterShaderReference<T>(this T entity, AssetReference value)
            where T : ConditionDefinition
        {
            entity.SetField("characterShaderReference", value);
            return entity;
        }

        public static T SetConditionEndParticleReference<T>(this T entity, AssetReference value)
            where T : ConditionDefinition
        {
            entity.SetField("conditionEndParticleReference", value);
            return entity;
        }

        public static T SetConditionParticleReference<T>(this T entity, AssetReference value)
            where T : ConditionDefinition
        {
            entity.SetField("conditionParticleReference", value);
            return entity;
        }

        public static T SetConditionStartParticleReference<T>(this T entity, AssetReference value)
            where T : ConditionDefinition
        {
            entity.SetField("conditionStartParticleReference", value);
            return entity;
        }

        public static T SetConditionType<T>(this T entity, ConditionType value)
            where T : ConditionDefinition
        {
            entity.SetField("conditionType", value);
            return entity;
        }

        public static T SetDurationParameter<T>(this T entity, int value)
            where T : ConditionDefinition
        {
            entity.SetField("durationParameter", value);
            return entity;
        }

        public static T SetDurationParameterDie<T>(this T entity, DieType value)
            where T : ConditionDefinition
        {
            entity.SetField("durationParameterDie", value);
            return entity;
        }

        public static T SetDurationType<T>(this T entity, DurationType value)
            where T : ConditionDefinition
        {
            entity.SetField("durationType", value);
            return entity;
        }

        public static T SetExplorationPackage<T>(this T entity, DecisionPackageDefinition value)
            where T : ConditionDefinition
        {
            entity.SetField("explorationPackage", value);
            return entity;
        }

        public static T SetFearSource<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("fearSource", value);
            return entity;
        }

        public static T SetForceBehavior<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("forceBehavior", value);
            return entity;
        }

        public static T SetInterruptionRequiresSavingThrow<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("interruptionRequiresSavingThrow", value);
            return entity;
        }

        public static T SetParentCondition<T>(this T entity, ConditionDefinition value)
            where T : ConditionDefinition
        {
            entity.SetField("parentCondition", value);
            return entity;
        }

        public static T SetPermanentlyRemovedIfExtraPlanar<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("permanentlyRemovedIfExtraPlanar", value);
            return entity;
        }

        public static T SetPossessive<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("possessive", value);
            return entity;
        }

        public static T SetRemovedFromTheGame<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("removedFromTheGame", value);
            return entity;
        }

        public static T SetSilentWhenAdded<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("silentWhenAdded", value);
            return entity;
        }

        public static T SetSilentWhenRemoved<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("silentWhenRemoved", value);
            return entity;
        }

        public static T SetSourceAbilityBonusMinValue<T>(this T entity, int value)
            where T : ConditionDefinition
        {
            entity.SetField("sourceAbilityBonusMinValue", value);
            return entity;
        }

        public static T SetSpecialDuration<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("specialDuration", value);
            return entity;
        }

        public static T SetSubsequentOnRemoval<T>(this T entity, ConditionDefinition value)
            where T : ConditionDefinition
        {
            entity.SetField("subsequentOnRemoval", value);
            return entity;
        }

        public static T SetTerminateWhenRemoved<T>(this T entity, bool value)
            where T : ConditionDefinition
        {
            entity.SetField("terminateWhenRemoved", value);
            return entity;
        }

        public static T SetTimeToWaitBeforeApplyingShader<T>(this T entity, float value)
            where T : ConditionDefinition
        {
            entity.SetField("timeToWaitBeforeApplyingShader", value);
            return entity;
        }

        public static T SetTimeToWaitBeforeRemovingShader<T>(this T entity, float value)
            where T : ConditionDefinition
        {
            entity.SetField("timeToWaitBeforeRemovingShader", value);
            return entity;
        }

        public static T SetTurnOccurence<T>(this T entity, TurnOccurenceType value)
            where T : ConditionDefinition
        {
            entity.SetField("turnOccurence", value);
            return entity;
        }
    }
}