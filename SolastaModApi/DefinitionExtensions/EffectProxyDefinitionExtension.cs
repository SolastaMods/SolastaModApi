using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EffectProxyDefinitionExtensions
    {
        public static EffectProxyDefinition SetAdditionalFeatures(this EffectProxyDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("additionalFeatures", value);
            return definition;
        }

        public static EffectProxyDefinition SetAddLightSource(this EffectProxyDefinition definition, bool value)
        {
            definition.SetField("addLightSource", value);
            return definition;
        }

        public static EffectProxyDefinition SetAttackImpactParticle(this EffectProxyDefinition definition, AssetReference value)
        {
            definition.SetField("attackImpactParticle", value);
            return definition;
        }

        public static EffectProxyDefinition SetAttackMethod(this EffectProxyDefinition definition, ProxyAttackMethod value)
        {
            definition.SetField("attackMethod", value);
            return definition;
        }

        public static EffectProxyDefinition SetAttackParticle(this EffectProxyDefinition definition, AssetReference value)
        {
            definition.SetField("attackParticle", value);
            return definition;
        }

        public static EffectProxyDefinition SetCanAttack(this EffectProxyDefinition definition, bool value)
        {
            definition.SetField("canAttack", value);
            return definition;
        }

        public static EffectProxyDefinition SetCanMove(this EffectProxyDefinition definition, bool value)
        {
            definition.SetField("canMove", value);
            return definition;
        }

        public static EffectProxyDefinition SetDamageDie(this EffectProxyDefinition definition, DieType value)
        {
            definition.SetField("damageDie", value);
            return definition;
        }

        public static EffectProxyDefinition SetDamageType(this EffectProxyDefinition definition, string value)
        {
            definition.SetField("damageType", value);
            return definition;
        }

        public static EffectProxyDefinition SetHasPortrait(this EffectProxyDefinition definition, bool value)
        {
            definition.SetField("hasPortrait", value);
            return definition;
        }

        public static EffectProxyDefinition SetHasPresentation(this EffectProxyDefinition definition, bool value)
        {
            definition.SetField("hasPresentation", value);
            return definition;
        }

        public static EffectProxyDefinition SetImpactsPlacement(this EffectProxyDefinition definition, bool value)
        {
            definition.SetField("impactsPlacement", value);
            return definition;
        }

        public static EffectProxyDefinition SetIsEmptyPresentation(this EffectProxyDefinition definition, bool value)
        {
            definition.SetField("isEmptyPresentation", value);
            return definition;
        }

        public static EffectProxyDefinition SetLightSourceForm(this EffectProxyDefinition definition, LightSourceForm value)
        {
            definition.SetField("lightSourceForm", value);
            return definition;
        }

        public static EffectProxyDefinition SetModelScale(this EffectProxyDefinition definition, float value)
        {
            definition.SetField("modelScale", value);
            return definition;
        }

        public static EffectProxyDefinition SetPortraitSpriteReference(this EffectProxyDefinition definition, AssetReferenceSprite value)
        {
            definition.SetField("portraitSpriteReference", value);
            return definition;
        }

        public static EffectProxyDefinition SetPrefabReference(this EffectProxyDefinition definition, AssetReference value)
        {
            definition.SetField("prefabReference", value);
            return definition;
        }

        public static EffectProxyDefinition SetShowWorldLocationFeedbacks(this EffectProxyDefinition definition, bool value)
        {
            definition.SetField("showWorldLocationFeedbacks", value);
            return definition;
        }

        public static EffectProxyDefinition SetSoundEffectOnHitDescription(this EffectProxyDefinition definition, SoundEffectOnHitDescription value)
        {
            definition.SetField("soundEffectOnHitDescription", value);
            return definition;
        }
    }
}