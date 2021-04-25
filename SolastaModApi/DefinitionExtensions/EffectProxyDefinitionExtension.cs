using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EffectProxyDefinitionExtensions
    {
        public static void SetAdditionalFeatures(this EffectProxyDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("additionalFeatures", value);
        }

        public static void SetAddLightSource(this EffectProxyDefinition definition, Boolean value)
        {
            definition.SetField("addLightSource", value);
        }

        public static void SetAttackImpactParticle(this EffectProxyDefinition definition, AssetReference value)
        {
            definition.SetField("attackImpactParticle", value);
        }

        public static void SetAttackMethod(this EffectProxyDefinition definition, ProxyAttackMethod value)
        {
            definition.SetField("attackMethod", value);
        }

        public static void SetAttackParticle(this EffectProxyDefinition definition, AssetReference value)
        {
            definition.SetField("attackParticle", value);
        }

        public static void SetCanAttack(this EffectProxyDefinition definition, Boolean value)
        {
            definition.SetField("canAttack", value);
        }

        public static void SetCanMove(this EffectProxyDefinition definition, Boolean value)
        {
            definition.SetField("canMove", value);
        }

        public static void SetDamageDie(this EffectProxyDefinition definition, DieType value)
        {
            definition.SetField("damageDie", value);
        }

        public static void SetDamageType(this EffectProxyDefinition definition, String value)
        {
            definition.SetField("damageType", value);
        }

        public static void SetHasPortrait(this EffectProxyDefinition definition, Boolean value)
        {
            definition.SetField("hasPortrait", value);
        }

        public static void SetHasPresentation(this EffectProxyDefinition definition, Boolean value)
        {
            definition.SetField("hasPresentation", value);
        }

        public static void SetImpactsPlacement(this EffectProxyDefinition definition, Boolean value)
        {
            definition.SetField("impactsPlacement", value);
        }

        public static void SetIsEmptyPresentation(this EffectProxyDefinition definition, Boolean value)
        {
            definition.SetField("isEmptyPresentation", value);
        }

        public static void SetLightSourceForm(this EffectProxyDefinition definition, LightSourceForm value)
        {
            definition.SetField("lightSourceForm", value);
        }

        public static void SetModelScale(this EffectProxyDefinition definition, Single value)
        {
            definition.SetField("modelScale", value);
        }

        public static void SetPortraitSpriteReference(this EffectProxyDefinition definition, AssetReferenceSprite value)
        {
            definition.SetField("portraitSpriteReference", value);
        }

        public static void SetPrefabReference(this EffectProxyDefinition definition, AssetReference value)
        {
            definition.SetField("prefabReference", value);
        }

        public static void SetShowWorldLocationFeedbacks(this EffectProxyDefinition definition, Boolean value)
        {
            definition.SetField("showWorldLocationFeedbacks", value);
        }

        public static void SetSoundEffectOnHitDescription(this EffectProxyDefinition definition, SoundEffectOnHitDescription value)
        {
            definition.SetField("soundEffectOnHitDescription", value);
        }
    }
}