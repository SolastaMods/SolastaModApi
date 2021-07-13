using HarmonyLib;
using TA.AI;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public class ConditionBuilder
    {
		private readonly ConditionDefinition condition;

		public ConditionBuilder()
		{
			condition = ScriptableObject.CreateInstance<ConditionDefinition>();
		}

		public void SetParentCondition(ConditionDefinition parentCondition)
        {
			Traverse.Create(condition).Field("parentCondition").SetValue(parentCondition);
		}

		public void SetConditionType(RuleDefinitions.ConditionType conditionType)
		{
			Traverse.Create(condition).Field("conditionType").SetValue(conditionType);
		}

		public void AddFeatures(FeatureDefinition features)
        {
			condition.Features.Add(features);
        }

		public void SetAllowMultipleInstances(bool allowMultipleInstances)
		{
			Traverse.Create(condition).Field("allowMultipleInstances").SetValue(allowMultipleInstances);
		}

		public void SetSilentWhenAddedOrRemoved(bool silentWhenAdded, bool silentWhenRemoved)
		{
			Traverse.Create(condition).Field("silentWhenAdded").SetValue(silentWhenAdded);
			Traverse.Create(condition).Field("silentWhenRemoved").SetValue(silentWhenRemoved);
		}

		public void SetTerminateWhenRemoved(bool terminateWhenRemoved)
		{
			Traverse.Create(condition).Field("terminateWhenRemoved").SetValue(terminateWhenRemoved);
		}

		public void SetSpecialDurationFields(bool specialDuration, RuleDefinitions.DurationType durationType, RuleDefinitions.DieType durationParameterDie, 
			int durationParameter, RuleDefinitions.TurnOccurenceType turnOccurence)
		{
			Traverse.Create(condition).Field("specialDuration").SetValue(specialDuration);
			Traverse.Create(condition).Field("durationType").SetValue(durationType);
			Traverse.Create(condition).Field("durationParameterDie").SetValue(durationParameterDie);
			Traverse.Create(condition).Field("durationParameter").SetValue(durationParameter);
			Traverse.Create(condition).Field("turnOccurence").SetValue(turnOccurence);
		}

		public void AddSpecialInterruptions(RuleDefinitions.ConditionInterruption specialInterruptions)
		{
			condition.SpecialInterruptions.Add(specialInterruptions);
		}

		public void SetInterruptionRequiresSavingThrow(bool interruptionRequiresSavingThrow)
        {
			Traverse.Create(condition).Field("interruptionRequiresSavingThrow").SetValue(interruptionRequiresSavingThrow);
		}

		public void AddConditionTags(string conditionTags)
        {
			condition.ConditionTags.Add(conditionTags);
        }

		public void AddRecurrentEffectForms(EffectForm recurrentEffectForms)
		{
			condition.RecurrentEffectForms.Add(recurrentEffectForms);
		}

		public void AddCancellingConditions(ConditionDefinition cancellingConditions)
		{
			condition.CancellingConditions.Add(cancellingConditions);
		}

		public void SetAdditionalDamageWhenHitFields(bool additionalDamageWhenHit, DamageDefinition additionalDamageType, ConditionDefinition.DamageQuantity additionalDamageQuantity,
			RuleDefinitions.DieType additionalDamageDieType, int additionalDamageDieNumber)
		{
			Traverse.Create(condition).Field("additionalDamageWhenHit").SetValue(additionalDamageWhenHit);
			Traverse.Create(condition).Field("additionalDamageType").SetValue(additionalDamageType.Name);
			Traverse.Create(condition).Field("additionalDamageQuantity").SetValue(additionalDamageQuantity);
			Traverse.Create(condition).Field("additionalDamageDieType").SetValue(additionalDamageDieType);
			Traverse.Create(condition).Field("additionalDamageDieNumber").SetValue(additionalDamageDieNumber);
		}

		public void SetAdditionalConditionWhenHitFields(bool additionalConditionWhenHit, ConditionDefinition additionalCondition, RuleDefinitions.DurationType additionalConditionDurationType, 
			int additionalConditionDurationParameter)
		{
			Traverse.Create(condition).Field("additionalConditionWhenHit").SetValue(additionalConditionWhenHit);
			Traverse.Create(condition).Field("additionalCondition").SetValue(additionalCondition);
			Traverse.Create(condition).Field("additionalConditionDurationType").SetValue(additionalConditionDurationType);
			Traverse.Create(condition).Field("additionalConditionDurationParameter").SetValue(additionalConditionDurationParameter);
		}

		public void SetParticleReferences(AssetReference conditionStartParticleReference, AssetReference conditionParticleReference, AssetReference conditionEndParticleReference,
			AssetReference characterShaderReference)
		{
			Traverse.Create(condition).Field("conditionStartParticleReference").SetValue(conditionStartParticleReference);
			Traverse.Create(condition).Field("conditionParticleReference").SetValue(conditionParticleReference);
			Traverse.Create(condition).Field("conditionEndParticleReference").SetValue(conditionEndParticleReference);
			Traverse.Create(condition).Field("characterShaderReference").SetValue(characterShaderReference);
		}

		public void SetTimeToWaitBeforeShader(float timeToWaitBeforeApplyingShader, float timeToWaitBeforeRemovingShader)
		{
			Traverse.Create(condition).Field("timeToWaitBeforeApplyingShader").SetValue(timeToWaitBeforeApplyingShader);
			Traverse.Create(condition).Field("timeToWaitBeforeRemovingShader").SetValue(timeToWaitBeforeRemovingShader);
		}

		//public void AddFeaturesToBrowse(FeatureDefinition featuresToBrowse)
		//{
		//	condition.EnumerateFeaturesToBrowse<>(featuresToBrowse);
		//}

		public void SetPossessive(bool possessive)
		{
			Traverse.Create(condition).Field("possessive").SetValue(possessive);
		}

		public void SetAmountOrigin(ConditionDefinition.OriginOfAmount amountOrigin, int baseAmount, bool additiveAmount, int sourceAbilityBonusMinValue)
		{
			Traverse.Create(condition).Field("amountOrigin").SetValue(amountOrigin);
			Traverse.Create(condition).Field("baseAmount").SetValue(baseAmount);
			Traverse.Create(condition).Field("additiveAmount").SetValue(additiveAmount);
			Traverse.Create(condition).Field("sourceAbilityBonusMinValue").SetValue(sourceAbilityBonusMinValue);
		}

		public void SetAmountOriginDefault(int sourceAbilityBonusMinValue)
		{
			//Traverse.Create(condition).Field("amountOrigin").SetValue(amountOrigin);
			//Traverse.Create(condition).Field("baseAmount").SetValue(baseAmount);
			//Traverse.Create(condition).Field("additiveAmount").SetValue(additiveAmount);
			Traverse.Create(condition).Field("sourceAbilityBonusMinValue").SetValue(sourceAbilityBonusMinValue);
		}

		public void SetSubsequentOnRemoval(ConditionDefinition subsequentOnRemoval)
		{
			Traverse.Create(condition).Field("subsequentOnRemoval").SetValue(subsequentOnRemoval);
		}

		public void SetForceBehavior(bool forceBehavior)
		{
			Traverse.Create(condition).Field("forceBehavior").SetValue(forceBehavior);
		}

		public void SetFearSource(bool fearSource)
		{
			Traverse.Create(condition).Field("fearSource").SetValue(fearSource);
		}

		public void SetBattlePackage(DecisionPackageDefinition battlePackage)
		{
			Traverse.Create(condition).Field("battlePackage").SetValue(battlePackage);
		}

		public void SetExplorationPackage(DecisionPackageDefinition explorationPackage)
		{
			Traverse.Create(condition).Field("explorationPackage").SetValue(explorationPackage);
		}

		public void SetRemovedFromTheGame(bool removedFromTheGame)
		{
			Traverse.Create(condition).Field("removedFromTheGame").SetValue(removedFromTheGame);
		}

		public void SetPermanentlyRemovedIfExtraPlanar(bool permanentlyRemovedIfExtraPlanar)
		{
			Traverse.Create(condition).Field("permanentlyRemovedIfExtraPlanar").SetValue(permanentlyRemovedIfExtraPlanar);
		}

		public void SetGuiPresentation(GuiPresentation gui)
		{
			Traverse.Create(condition).Field("guiPresentation").SetValue(gui);
		}

		public void SetName(string name, string guid)
		{
			Traverse.Create(condition).Field("name").SetValue(name);
			condition.name = name;
			Traverse.Create(condition).Field("guid").SetValue(guid);
		}

		public ConditionDefinition Build()
		{
			DatabaseRepository.GetDatabase<ConditionDefinition>().Add(condition);
			return condition;
		}
	}
}
