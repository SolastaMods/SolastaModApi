using HarmonyLib;
//using TA.AI;
using UnityEngine;
using UnityEngine.AddressableAssets;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System;

namespace SolastaModApi
{
    public class EffectParticleParametersBuilder
    {
        private readonly EffectParticleParameters effectParticle;

        public EffectParticleParametersBuilder()
        {
            effectParticle = new EffectParticleParameters();
        }


        public void SetEffectParticleParametersAll(AssetReference casterParticleReference, AssetReference casterSelfParticleReference, AssetReference casterQuickSpellParticleReference,
            AssetReference targetParticleReference, AssetReference effectParticleReference, AssetReference zoneParticleReference, AssetReference impactParticleReference,
            AssetReference activeEffectCellStartParticleReference, AssetReference activeEffectCellParticleReference, AssetReference activeEffectCellEndParticleReference,
            AssetReference activeEffectSurfaceStartParticleReference, AssetReference activeEffectSurfaceParticleReference, AssetReference activeEffectSurfaceEndParticleReference,
            AssetReference emissiveBorderCellStartParticleReference, AssetReference emissiveBorderCellParticleReference, AssetReference emissiveBorderCellEndParticleReference, 
            AssetReference emissiveBorderSurfaceStartParticleReference, AssetReference emissiveBorderSurfaceParticleReference, AssetReference emissiveBorderSurfaceEndParticleReference, 
            AssetReference conditionStartParticleReference, AssetReference conditionParticleReference, AssetReference conditionEndParticleReference, 
            bool applyEmissionColorOnWeapons, Color emissionColor, float emissionColorFadeInDuration, float emissionColorFadeOutDuration)
        {
            Traverse.Create(effectParticle).Field("casterParticleReference").SetValue(casterParticleReference);
            Traverse.Create(effectParticle).Field("casterSelfParticleReference").SetValue(casterSelfParticleReference);
            Traverse.Create(effectParticle).Field("casterQuickSpellParticleReference").SetValue(casterQuickSpellParticleReference);
            Traverse.Create(effectParticle).Field("targetParticleReference").SetValue(targetParticleReference);
            Traverse.Create(effectParticle).Field("effectParticleReference").SetValue(effectParticleReference);
            Traverse.Create(effectParticle).Field("zoneParticleReference").SetValue(zoneParticleReference);
            Traverse.Create(effectParticle).Field("impactParticleReference").SetValue(impactParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectCellStartParticleReference").SetValue(activeEffectCellStartParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectCellParticleReference").SetValue(activeEffectCellParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectCellEndParticleReference").SetValue(activeEffectCellEndParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectSurfaceStartParticleReference").SetValue(activeEffectSurfaceStartParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectSurfaceParticleReference").SetValue(activeEffectSurfaceParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectSurfaceEndParticleReference").SetValue(activeEffectSurfaceEndParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderCellStartParticleReference").SetValue(emissiveBorderCellStartParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderCellParticleReference").SetValue(emissiveBorderCellParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderCellEndParticleReference").SetValue(emissiveBorderCellEndParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderSurfaceStartParticleReference").SetValue(emissiveBorderSurfaceStartParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderSurfaceParticleReference").SetValue(emissiveBorderSurfaceParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderSurfaceEndParticleReference").SetValue(emissiveBorderSurfaceEndParticleReference);
            Traverse.Create(effectParticle).Field("conditionStartParticleReference").SetValue(conditionStartParticleReference);
            Traverse.Create(effectParticle).Field("conditionParticleReference").SetValue(conditionParticleReference);
            Traverse.Create(effectParticle).Field("conditionEndParticleReference").SetValue(conditionEndParticleReference);
            Traverse.Create(effectParticle).Field("applyEmissionColorOnWeapons").SetValue(applyEmissionColorOnWeapons);
            Traverse.Create(effectParticle).Field("emissionColor").SetValue(emissionColor);
            Traverse.Create(effectParticle).Field("emissionColorFadeInDuration").SetValue(emissionColorFadeInDuration);
            Traverse.Create(effectParticle).Field("emissionColorFadeOutDuration").SetValue(emissionColorFadeOutDuration);
        }

        public void SetEffectParticleParametersEffectDescription(AssetReference casterParticleReference, AssetReference casterSelfParticleReference, AssetReference casterQuickSpellParticleReference,
            AssetReference targetParticleReference, AssetReference effectParticleReference, AssetReference zoneParticleReference, AssetReference impactParticleReference,
            AssetReference activeEffectCellStartParticleReference, AssetReference activeEffectCellParticleReference, AssetReference activeEffectCellEndParticleReference,
            AssetReference activeEffectSurfaceStartParticleReference, AssetReference activeEffectSurfaceParticleReference, AssetReference activeEffectSurfaceEndParticleReference,
            AssetReference emissiveBorderCellStartParticleReference, AssetReference emissiveBorderCellParticleReference, AssetReference emissiveBorderCellEndParticleReference,
            AssetReference emissiveBorderSurfaceStartParticleReference, AssetReference emissiveBorderSurfaceParticleReference, AssetReference emissiveBorderSurfaceEndParticleReference,
            AssetReference conditionStartParticleReference, AssetReference conditionParticleReference, AssetReference conditionEndParticleReference)
        {
            Traverse.Create(effectParticle).Field("casterParticleReference").SetValue(casterParticleReference);
            Traverse.Create(effectParticle).Field("casterSelfParticleReference").SetValue(casterSelfParticleReference);
            Traverse.Create(effectParticle).Field("casterQuickSpellParticleReference").SetValue(casterQuickSpellParticleReference);
            Traverse.Create(effectParticle).Field("targetParticleReference").SetValue(targetParticleReference);
            Traverse.Create(effectParticle).Field("effectParticleReference").SetValue(effectParticleReference);
            Traverse.Create(effectParticle).Field("zoneParticleReference").SetValue(zoneParticleReference);
            Traverse.Create(effectParticle).Field("impactParticleReference").SetValue(impactParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectCellStartParticleReference").SetValue(activeEffectCellStartParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectCellParticleReference").SetValue(activeEffectCellParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectCellEndParticleReference").SetValue(activeEffectCellEndParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectSurfaceStartParticleReference").SetValue(activeEffectSurfaceStartParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectSurfaceParticleReference").SetValue(activeEffectSurfaceParticleReference);
            Traverse.Create(effectParticle).Field("activeEffectSurfaceEndParticleReference").SetValue(activeEffectSurfaceEndParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderCellStartParticleReference").SetValue(emissiveBorderCellStartParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderCellParticleReference").SetValue(emissiveBorderCellParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderCellEndParticleReference").SetValue(emissiveBorderCellEndParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderSurfaceStartParticleReference").SetValue(emissiveBorderSurfaceStartParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderSurfaceParticleReference").SetValue(emissiveBorderSurfaceParticleReference);
            Traverse.Create(effectParticle).Field("emissiveBorderSurfaceEndParticleReference").SetValue(emissiveBorderSurfaceEndParticleReference);
            Traverse.Create(effectParticle).Field("conditionStartParticleReference").SetValue(conditionStartParticleReference);
            Traverse.Create(effectParticle).Field("conditionParticleReference").SetValue(conditionParticleReference);
            Traverse.Create(effectParticle).Field("conditionEndParticleReference").SetValue(conditionEndParticleReference);
            //Traverse.Create(effectParticle).Field("applyEmissionColorOnWeapons").SetValue(applyEmissionColorOnWeapons);
            //Traverse.Create(effectParticle).Field("emissionColor").SetValue(emissionColor);
            //Traverse.Create(effectParticle).Field("emissionColorFadeInDuration").SetValue(emissionColorFadeInDuration);
            //Traverse.Create(effectParticle).Field("emissionColorFadeOutDuration").SetValue(emissionColorFadeOutDuration);
        }

        //public void SetEffectParticleParametersCondition(AssetReference conditionStartParticleReference, AssetReference conditionParticleReference, AssetReference conditionEndParticleReference,
        //    AssetReference characterShaderReference)
		//{
		//	Traverse.Create(effectParticle).Field("conditionStartParticleReference").SetValue(conditionStartParticleReference);
		//	Traverse.Create(effectParticle).Field("conditionParticleReference").SetValue(conditionParticleReference);
		//	Traverse.Create(effectParticle).Field("conditionEndParticleReference").SetValue(conditionEndParticleReference);
		//	Traverse.Create(effectParticle).Field("characterShaderReference").SetValue(characterShaderReference);
		//}

        public EffectParticleParameters Build()
        {
            return effectParticle;
        }

    }
}
