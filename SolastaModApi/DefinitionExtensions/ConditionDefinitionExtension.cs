using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System;
using TA.AI;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ConditionDefinitionExtensions
    {
        public static void SetAdditionalCondition(this ConditionDefinition definition, ConditionDefinition value)
        {
            definition.SetField("additionalCondition", value);
        }

        public static void SetAdditionalConditionDurationParameter(this ConditionDefinition definition, Int32 value)
        {
            definition.SetField("additionalConditionDurationParameter", value);
        }

        public static void SetAdditionalConditionDurationType(this ConditionDefinition definition, DurationType value)
        {
            definition.SetField("additionalConditionDurationType", value);
        }

        public static void SetAdditionalConditionWhenHit(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("additionalConditionWhenHit", value);
        }

        public static void SetAdditionalDamageDieNumber(this ConditionDefinition definition, Int32 value)
        {
            definition.SetField("additionalDamageDieNumber", value);
        }

        public static void SetAdditionalDamageDieType(this ConditionDefinition definition, DieType value)
        {
            definition.SetField("additionalDamageDieType", value);
        }

        public static void SetAdditionalDamageQuantity(this ConditionDefinition definition, ConditionDefinition.DamageQuantity value)
        {
            definition.SetField("additionalDamageQuantity", value);
        }

        public static void SetAdditionalDamageType(this ConditionDefinition definition, String value)
        {
            definition.SetField("additionalDamageType", value);
        }

        public static void SetAdditionalDamageWhenHit(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("additionalDamageWhenHit", value);
        }

        public static void SetAdditiveAmount(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("additiveAmount", value);
        }

        public static void SetAllowMultipleInstances(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("allowMultipleInstances", value);
        }

        public static void SetAmountOrigin(this ConditionDefinition definition, ConditionDefinition.OriginOfAmount value)
        {
            definition.SetField("amountOrigin", value);
        }

        public static void SetBaseAmount(this ConditionDefinition definition, Int32 value)
        {
            definition.SetField("baseAmount", value);
        }

        public static void SetBattlePackage(this ConditionDefinition definition, DecisionPackageDefinition value)
        {
            definition.SetField("battlePackage", value);
        }

        public static void SetCancellingConditions(this ConditionDefinition definition, List<ConditionDefinition> value)
        {
            definition.SetField("cancellingConditions", value);
        }

        public static void SetCharacterShaderReference(this ConditionDefinition definition, AssetReference value)
        {
            definition.SetField("characterShaderReference", value);
        }

        public static void SetConditionEndParticleReference(this ConditionDefinition definition, AssetReference value)
        {
            definition.SetField("conditionEndParticleReference", value);
        }

        public static void SetConditionParticleReference(this ConditionDefinition definition, AssetReference value)
        {
            definition.SetField("conditionParticleReference", value);
        }

        public static void SetConditionStartParticleReference(this ConditionDefinition definition, AssetReference value)
        {
            definition.SetField("conditionStartParticleReference", value);
        }

        public static void SetConditionTags(this ConditionDefinition definition, List<String> value)
        {
            definition.SetField("conditionTags", value);
        }

        public static void SetConditionType(this ConditionDefinition definition, ConditionType value)
        {
            definition.SetField("conditionType", value);
        }

        public static void SetDurationParameter(this ConditionDefinition definition, Int32 value)
        {
            definition.SetField("durationParameter", value);
        }

        public static void SetDurationParameterDie(this ConditionDefinition definition, DieType value)
        {
            definition.SetField("durationParameterDie", value);
        }

        public static void SetDurationType(this ConditionDefinition definition, DurationType value)
        {
            definition.SetField("durationType", value);
        }

        public static void SetExplorationPackage(this ConditionDefinition definition, DecisionPackageDefinition value)
        {
            definition.SetField("explorationPackage", value);
        }

        public static void SetFearSource(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("fearSource", value);
        }

        public static void SetFeatures(this ConditionDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
        }

        public static void SetFeaturesToBrowse(this ConditionDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("featuresToBrowse", value);
        }

        public static void SetForceBehavior(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("forceBehavior", value);
        }

        public static void SetInterruptionRequiresSavingThrow(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("interruptionRequiresSavingThrow", value);
        }

        public static void SetParentCondition(this ConditionDefinition definition, ConditionDefinition value)
        {
            definition.SetField("parentCondition", value);
        }

        public static void SetPermanentlyRemovedIfExtraPlanar(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("permanentlyRemovedIfExtraPlanar", value);
        }

        public static void SetPossessive(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("possessive", value);
        }

        public static void SetRecurrentEffectForms(this ConditionDefinition definition, List<EffectForm> value)
        {
            definition.SetField("recurrentEffectForms", value);
        }

        public static void SetRemovedFromTheGame(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("removedFromTheGame", value);
        }

        public static void SetSilentWhenAdded(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("silentWhenAdded", value);
        }

        public static void SetSilentWhenRemoved(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("silentWhenRemoved", value);
        }

        public static void SetSourceAbilityBonusMinValue(this ConditionDefinition definition, Int32 value)
        {
            definition.SetField("sourceAbilityBonusMinValue", value);
        }

        public static void SetSpecialDuration(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("specialDuration", value);
        }

        public static void SetSpecialInterruptions(this ConditionDefinition definition, List<ConditionInterruption> value)
        {
            definition.SetField("specialInterruptions", value);
        }

        public static void SetSubsequentOnRemoval(this ConditionDefinition definition, ConditionDefinition value)
        {
            definition.SetField("subsequentOnRemoval", value);
        }

        public static void SetTerminateWhenRemoved(this ConditionDefinition definition, Boolean value)
        {
            definition.SetField("terminateWhenRemoved", value);
        }

        public static void SetTimeToWaitBeforeApplyingShader(this ConditionDefinition definition, Single value)
        {
            definition.SetField("timeToWaitBeforeApplyingShader", value);
        }

        public static void SetTimeToWaitBeforeRemovingShader(this ConditionDefinition definition, Single value)
        {
            definition.SetField("timeToWaitBeforeRemovingShader", value);
        }

        public static void SetTurnOccurence(this ConditionDefinition definition, TurnOccurenceType value)
        {
            definition.SetField("turnOccurence", value);
        }
    }
}