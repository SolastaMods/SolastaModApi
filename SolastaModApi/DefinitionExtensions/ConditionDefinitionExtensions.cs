using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using TA.AI;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class ConditionDefinitionExtensions
    {
        public static T SetAdditionalCondition<T>(this T definition, ConditionDefinition value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalCondition", value);
            return definition;
        }

        public static T SetAdditionalConditionDurationParameter<T>(this T definition, int value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalConditionDurationParameter", value);
            return definition;
        }

        public static T SetAdditionalConditionDurationType<T>(this T definition, DurationType value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalConditionDurationType", value);
            return definition;
        }

        public static T SetAdditionalConditionWhenHit<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalConditionWhenHit", value);
            return definition;
        }

        public static T SetAdditionalDamageDieNumber<T>(this T definition, int value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalDamageDieNumber", value);
            return definition;
        }

        public static T SetAdditionalDamageDieType<T>(this T definition, DieType value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalDamageDieType", value);
            return definition;
        }

        public static T SetAdditionalDamageQuantity<T>(this T definition, ConditionDefinition.DamageQuantity value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalDamageQuantity", value);
            return definition;
        }

        public static T SetAdditionalDamageType<T>(this T definition, string value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalDamageType", value);
            return definition;
        }

        public static T SetAdditionalDamageWhenHit<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("additionalDamageWhenHit", value);
            return definition;
        }

        public static T SetAdditiveAmount<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("additiveAmount", value);
            return definition;
        }

        public static T SetAllowMultipleInstances<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("allowMultipleInstances", value);
            return definition;
        }

        public static T SetAmountOrigin<T>(this T definition, ConditionDefinition.OriginOfAmount value)
            where T : ConditionDefinition
        {
            definition.SetField("amountOrigin", value);
            return definition;
        }

        public static T SetBaseAmount<T>(this T definition, int value)
            where T : ConditionDefinition
        {
            definition.SetField("baseAmount", value);
            return definition;
        }

        public static T SetBattlePackage<T>(this T definition, DecisionPackageDefinition value)
            where T : ConditionDefinition
        {
            definition.SetField("battlePackage", value);
            return definition;
        }

        public static T SetCharacterShaderReference<T>(this T definition, AssetReference value)
            where T : ConditionDefinition
        {
            definition.SetField("characterShaderReference", value);
            return definition;
        }

        public static T SetConditionEndParticleReference<T>(this T definition, AssetReference value)
            where T : ConditionDefinition
        {
            definition.SetField("conditionEndParticleReference", value);
            return definition;
        }

        public static T SetConditionParticleReference<T>(this T definition, AssetReference value)
            where T : ConditionDefinition
        {
            definition.SetField("conditionParticleReference", value);
            return definition;
        }

        public static T SetConditionStartParticleReference<T>(this T definition, AssetReference value)
            where T : ConditionDefinition
        {
            definition.SetField("conditionStartParticleReference", value);
            return definition;
        }

        public static T SetConditionType<T>(this T definition, ConditionType value)
            where T : ConditionDefinition
        {
            definition.SetField("conditionType", value);
            return definition;
        }

        public static T SetDurationParameter<T>(this T definition, int value)
            where T : ConditionDefinition
        {
            definition.SetField("durationParameter", value);
            return definition;
        }

        public static T SetDurationParameterDie<T>(this T definition, DieType value)
            where T : ConditionDefinition
        {
            definition.SetField("durationParameterDie", value);
            return definition;
        }

        public static T SetDurationType<T>(this T definition, DurationType value)
            where T : ConditionDefinition
        {
            definition.SetField("durationType", value);
            return definition;
        }

        public static T SetExplorationPackage<T>(this T definition, DecisionPackageDefinition value)
            where T : ConditionDefinition
        {
            definition.SetField("explorationPackage", value);
            return definition;
        }

        public static T SetFearSource<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("fearSource", value);
            return definition;
        }

        public static T SetForceBehavior<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("forceBehavior", value);
            return definition;
        }

        public static T SetInterruptionRequiresSavingThrow<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("interruptionRequiresSavingThrow", value);
            return definition;
        }

        public static T SetParentCondition<T>(this T definition, ConditionDefinition value)
            where T : ConditionDefinition
        {
            definition.SetField("parentCondition", value);
            return definition;
        }

        public static T SetPermanentlyRemovedIfExtraPlanar<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("permanentlyRemovedIfExtraPlanar", value);
            return definition;
        }

        public static T SetPossessive<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("possessive", value);
            return definition;
        }

        public static T SetRemovedFromTheGame<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("removedFromTheGame", value);
            return definition;
        }

        public static T SetSilentWhenAdded<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("silentWhenAdded", value);
            return definition;
        }

        public static T SetSilentWhenRemoved<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("silentWhenRemoved", value);
            return definition;
        }

        public static T SetSourceAbilityBonusMinValue<T>(this T definition, int value)
            where T : ConditionDefinition
        {
            definition.SetField("sourceAbilityBonusMinValue", value);
            return definition;
        }

        public static T SetSpecialDuration<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("specialDuration", value);
            return definition;
        }

        public static T SetSubsequentOnRemoval<T>(this T definition, ConditionDefinition value)
            where T : ConditionDefinition
        {
            definition.SetField("subsequentOnRemoval", value);
            return definition;
        }

        public static T SetTerminateWhenRemoved<T>(this T definition, bool value)
            where T : ConditionDefinition
        {
            definition.SetField("terminateWhenRemoved", value);
            return definition;
        }

        public static T SetTimeToWaitBeforeApplyingShader<T>(this T definition, float value)
            where T : ConditionDefinition
        {
            definition.SetField("timeToWaitBeforeApplyingShader", value);
            return definition;
        }

        public static T SetTimeToWaitBeforeRemovingShader<T>(this T definition, float value)
            where T : ConditionDefinition
        {
            definition.SetField("timeToWaitBeforeRemovingShader", value);
            return definition;
        }

        public static T SetTurnOccurence<T>(this T definition, TurnOccurenceType value)
            where T : ConditionDefinition
        {
            definition.SetField("turnOccurence", value);
            return definition;
        }
    }
}