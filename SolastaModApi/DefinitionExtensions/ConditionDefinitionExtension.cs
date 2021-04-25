using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using TA.AI;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ConditionDefinitionExtensions
    {
        public static ConditionDefinition SetAdditionalCondition(this ConditionDefinition definition, ConditionDefinition value)
        {
            definition.SetField("additionalCondition", value);
            return definition;
        }

        public static ConditionDefinition SetAdditionalConditionDurationParameter(this ConditionDefinition definition, int value)
        {
            definition.SetField("additionalConditionDurationParameter", value);
            return definition;
        }

        public static ConditionDefinition SetAdditionalConditionDurationType(this ConditionDefinition definition, DurationType value)
        {
            definition.SetField("additionalConditionDurationType", value);
            return definition;
        }

        public static ConditionDefinition SetAdditionalConditionWhenHit(this ConditionDefinition definition, bool value)
        {
            definition.SetField("additionalConditionWhenHit", value);
            return definition;
        }

        public static ConditionDefinition SetAdditionalDamageDieNumber(this ConditionDefinition definition, int value)
        {
            definition.SetField("additionalDamageDieNumber", value);
            return definition;
        }

        public static ConditionDefinition SetAdditionalDamageDieType(this ConditionDefinition definition, DieType value)
        {
            definition.SetField("additionalDamageDieType", value);
            return definition;
        }

        public static ConditionDefinition SetAdditionalDamageQuantity(this ConditionDefinition definition, ConditionDefinition.DamageQuantity value)
        {
            definition.SetField("additionalDamageQuantity", value);
            return definition;
        }

        public static ConditionDefinition SetAdditionalDamageType(this ConditionDefinition definition, string value)
        {
            definition.SetField("additionalDamageType", value);
            return definition;
        }

        public static ConditionDefinition SetAdditionalDamageWhenHit(this ConditionDefinition definition, bool value)
        {
            definition.SetField("additionalDamageWhenHit", value);
            return definition;
        }

        public static ConditionDefinition SetAdditiveAmount(this ConditionDefinition definition, bool value)
        {
            definition.SetField("additiveAmount", value);
            return definition;
        }

        public static ConditionDefinition SetAllowMultipleInstances(this ConditionDefinition definition, bool value)
        {
            definition.SetField("allowMultipleInstances", value);
            return definition;
        }

        public static ConditionDefinition SetAmountOrigin(this ConditionDefinition definition, ConditionDefinition.OriginOfAmount value)
        {
            definition.SetField("amountOrigin", value);
            return definition;
        }

        public static ConditionDefinition SetBaseAmount(this ConditionDefinition definition, int value)
        {
            definition.SetField("baseAmount", value);
            return definition;
        }

        public static ConditionDefinition SetBattlePackage(this ConditionDefinition definition, DecisionPackageDefinition value)
        {
            definition.SetField("battlePackage", value);
            return definition;
        }

        public static ConditionDefinition SetCancellingConditions(this ConditionDefinition definition, List<ConditionDefinition> value)
        {
            definition.SetField("cancellingConditions", value);
            return definition;
        }

        public static ConditionDefinition SetCharacterShaderReference(this ConditionDefinition definition, AssetReference value)
        {
            definition.SetField("characterShaderReference", value);
            return definition;
        }

        public static ConditionDefinition SetConditionEndParticleReference(this ConditionDefinition definition, AssetReference value)
        {
            definition.SetField("conditionEndParticleReference", value);
            return definition;
        }

        public static ConditionDefinition SetConditionParticleReference(this ConditionDefinition definition, AssetReference value)
        {
            definition.SetField("conditionParticleReference", value);
            return definition;
        }

        public static ConditionDefinition SetConditionStartParticleReference(this ConditionDefinition definition, AssetReference value)
        {
            definition.SetField("conditionStartParticleReference", value);
            return definition;
        }

        public static ConditionDefinition SetConditionTags(this ConditionDefinition definition, List<string> value)
        {
            definition.SetField("conditionTags", value);
            return definition;
        }

        public static ConditionDefinition SetConditionType(this ConditionDefinition definition, ConditionType value)
        {
            definition.SetField("conditionType", value);
            return definition;
        }

        public static ConditionDefinition SetDurationParameter(this ConditionDefinition definition, int value)
        {
            definition.SetField("durationParameter", value);
            return definition;
        }

        public static ConditionDefinition SetDurationParameterDie(this ConditionDefinition definition, DieType value)
        {
            definition.SetField("durationParameterDie", value);
            return definition;
        }

        public static ConditionDefinition SetDurationType(this ConditionDefinition definition, DurationType value)
        {
            definition.SetField("durationType", value);
            return definition;
        }

        public static ConditionDefinition SetExplorationPackage(this ConditionDefinition definition, DecisionPackageDefinition value)
        {
            definition.SetField("explorationPackage", value);
            return definition;
        }

        public static ConditionDefinition SetFearSource(this ConditionDefinition definition, bool value)
        {
            definition.SetField("fearSource", value);
            return definition;
        }

        public static ConditionDefinition SetFeatures(this ConditionDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
            return definition;
        }

        public static ConditionDefinition SetFeaturesToBrowse(this ConditionDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("featuresToBrowse", value);
            return definition;
        }

        public static ConditionDefinition SetForceBehavior(this ConditionDefinition definition, bool value)
        {
            definition.SetField("forceBehavior", value);
            return definition;
        }

        public static ConditionDefinition SetInterruptionRequiresSavingThrow(this ConditionDefinition definition, bool value)
        {
            definition.SetField("interruptionRequiresSavingThrow", value);
            return definition;
        }

        public static ConditionDefinition SetParentCondition(this ConditionDefinition definition, ConditionDefinition value)
        {
            definition.SetField("parentCondition", value);
            return definition;
        }

        public static ConditionDefinition SetPermanentlyRemovedIfExtraPlanar(this ConditionDefinition definition, bool value)
        {
            definition.SetField("permanentlyRemovedIfExtraPlanar", value);
            return definition;
        }

        public static ConditionDefinition SetPossessive(this ConditionDefinition definition, bool value)
        {
            definition.SetField("possessive", value);
            return definition;
        }

        public static ConditionDefinition SetRecurrentEffectForms(this ConditionDefinition definition, List<EffectForm> value)
        {
            definition.SetField("recurrentEffectForms", value);
            return definition;
        }

        public static ConditionDefinition SetRemovedFromTheGame(this ConditionDefinition definition, bool value)
        {
            definition.SetField("removedFromTheGame", value);
            return definition;
        }

        public static ConditionDefinition SetSilentWhenAdded(this ConditionDefinition definition, bool value)
        {
            definition.SetField("silentWhenAdded", value);
            return definition;
        }

        public static ConditionDefinition SetSilentWhenRemoved(this ConditionDefinition definition, bool value)
        {
            definition.SetField("silentWhenRemoved", value);
            return definition;
        }

        public static ConditionDefinition SetSourceAbilityBonusMinValue(this ConditionDefinition definition, int value)
        {
            definition.SetField("sourceAbilityBonusMinValue", value);
            return definition;
        }

        public static ConditionDefinition SetSpecialDuration(this ConditionDefinition definition, bool value)
        {
            definition.SetField("specialDuration", value);
            return definition;
        }

        public static ConditionDefinition SetSpecialInterruptions(this ConditionDefinition definition, List<ConditionInterruption> value)
        {
            definition.SetField("specialInterruptions", value);
            return definition;
        }

        public static ConditionDefinition SetSubsequentOnRemoval(this ConditionDefinition definition, ConditionDefinition value)
        {
            definition.SetField("subsequentOnRemoval", value);
            return definition;
        }

        public static ConditionDefinition SetTerminateWhenRemoved(this ConditionDefinition definition, bool value)
        {
            definition.SetField("terminateWhenRemoved", value);
            return definition;
        }

        public static ConditionDefinition SetTimeToWaitBeforeApplyingShader(this ConditionDefinition definition, float value)
        {
            definition.SetField("timeToWaitBeforeApplyingShader", value);
            return definition;
        }

        public static ConditionDefinition SetTimeToWaitBeforeRemovingShader(this ConditionDefinition definition, float value)
        {
            definition.SetField("timeToWaitBeforeRemovingShader", value);
            return definition;
        }

        public static ConditionDefinition SetTurnOccurence(this ConditionDefinition definition, TurnOccurenceType value)
        {
            definition.SetField("turnOccurence", value);
            return definition;
        }
    }
}