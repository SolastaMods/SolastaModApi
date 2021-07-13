using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace SolastaModApi
{
    public class PowerFeatureBuilder
    {
        private readonly FeatureDefinitionPower power;

        public PowerFeatureBuilder()
        {
            power = ScriptableObject.CreateInstance<FeatureDefinitionPower>();
        }

        public void SetEffectDescription(EffectDescription effectDescription)
        {
            Traverse.Create(power).Field("effectDescription").SetValue(effectDescription);
        }


        public void SetDelegatedToAction(bool delegatedToAction)
        {
            Traverse.Create(power).Field("delegatedToAction").SetValue(delegatedToAction);
        }


        public void SetActivationTime(RuleDefinitions.ActivationTime activationTime)
        {
            Traverse.Create(power).Field("activationTime").SetValue(activationTime);
        }

        public void SetReactionContext(RuleDefinitions.ReactionTriggerContext reactionContext)
        {
            Traverse.Create(power).Field("reactionContext").SetValue(reactionContext);
        }

        public void SetRechargeRate(RuleDefinitions.RechargeRate rechargeRate)
        {
            Traverse.Create(power).Field("rechargeRate").SetValue(rechargeRate);
        }

        public void SetCostPerUse(int costPerUse)
        {
            Traverse.Create(power).Field("costPerUse").SetValue(costPerUse);
        }

        public void SetSpellcastingFeature(FeatureDefinitionCastSpell spellcastingFeature)
        {
            Traverse.Create(power).Field("spellcastingFeature").SetValue(spellcastingFeature);
        }

        public void SetUsesDetermination(RuleDefinitions.UsesDetermination usesDetermination)
        {
            Traverse.Create(power).Field("usesDetermination").SetValue(usesDetermination);
        }

        public void SetUsesAbilityScoreName(string usesAbilityScoreName)
        {
            Traverse.Create(power).Field("usesAbilityScoreName").SetValue(usesAbilityScoreName);
        }

        public void SetFixedUsesPerRecharge(int fixedUsesPerRecharge)
        {
            Traverse.Create(power).Field("fixedUsesPerRecharge").SetValue(fixedUsesPerRecharge);
        }

        public void SetAbilityScore(string abilityScore)
        {
            Traverse.Create(power).Field("abilityScore").SetValue(abilityScore);
        }

        public void SetAbilityScoreBonusToAttack(bool abilityScoreBonusToAttack)
        {
            Traverse.Create(power).Field("abilityScoreBonusToAttack").SetValue(abilityScoreBonusToAttack);
        }

        public void SetProficiencyBonusToAttack(bool proficiencyBonusToAttack)
        {
            Traverse.Create(power).Field("proficiencyBonusToAttack").SetValue(proficiencyBonusToAttack);
        }

        public void SetShowCasting(bool showCasting)
        {
            Traverse.Create(power).Field("showCasting").SetValue(showCasting);
        }

        public void SetShortTitleOverride(string shortTitleOverride)
        {
            Traverse.Create(power).Field("shortTitleOverride").SetValue(shortTitleOverride);
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(power).Field("guiPresentation").SetValue(gui);
        }

        public void SetName(string name, string guid)
        {
            Traverse.Create(power).Field("name").SetValue(name);
            power.name = name;
            Traverse.Create(power).Field("guid").SetValue(guid);
        }

        public FeatureDefinitionPower Build()
        {
            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(power);
            return power;
        }

    }
}
