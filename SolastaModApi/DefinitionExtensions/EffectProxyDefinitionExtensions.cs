using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class EffectProxyDefinitionExtensions
    {
        public static T SetAdditionalFeatures<T>(this T definition, List<FeatureDefinition> value)
            where T : EffectProxyDefinition
        {
            definition.SetField("additionalFeatures", value);
            return definition;
        }

        public static T SetAddLightSource<T>(this T definition, bool value)
            where T : EffectProxyDefinition
        {
            definition.SetField("addLightSource", value);
            return definition;
        }

        public static T SetAttackImpactParticle<T>(this T definition, AssetReference value)
            where T : EffectProxyDefinition
        {
            definition.SetField("attackImpactParticle", value);
            return definition;
        }

        public static T SetAttackMethod<T>(this T definition, ProxyAttackMethod value)
            where T : EffectProxyDefinition
        {
            definition.SetField("attackMethod", value);
            return definition;
        }

        public static T SetAttackParticle<T>(this T definition, AssetReference value)
            where T : EffectProxyDefinition
        {
            definition.SetField("attackParticle", value);
            return definition;
        }

        public static T SetCanAttack<T>(this T definition, bool value)
            where T : EffectProxyDefinition
        {
            definition.SetField("canAttack", value);
            return definition;
        }

        public static T SetCanMove<T>(this T definition, bool value)
            where T : EffectProxyDefinition
        {
            definition.SetField("canMove", value);
            return definition;
        }

        public static T SetDamageDie<T>(this T definition, DieType value)
            where T : EffectProxyDefinition
        {
            definition.SetField("damageDie", value);
            return definition;
        }

        public static T SetDamageType<T>(this T definition, string value)
            where T : EffectProxyDefinition
        {
            definition.SetField("damageType", value);
            return definition;
        }

        public static T SetHasPortrait<T>(this T definition, bool value)
            where T : EffectProxyDefinition
        {
            definition.SetField("hasPortrait", value);
            return definition;
        }

        public static T SetHasPresentation<T>(this T definition, bool value)
            where T : EffectProxyDefinition
        {
            definition.SetField("hasPresentation", value);
            return definition;
        }

        public static T SetImpactsPlacement<T>(this T definition, bool value)
            where T : EffectProxyDefinition
        {
            definition.SetField("impactsPlacement", value);
            return definition;
        }

        public static T SetIsEmptyPresentation<T>(this T definition, bool value)
            where T : EffectProxyDefinition
        {
            definition.SetField("isEmptyPresentation", value);
            return definition;
        }

        public static T SetLightSourceForm<T>(this T definition, LightSourceForm value)
            where T : EffectProxyDefinition
        {
            definition.SetField("lightSourceForm", value);
            return definition;
        }

        public static T SetModelScale<T>(this T definition, float value)
            where T : EffectProxyDefinition
        {
            definition.SetField("modelScale", value);
            return definition;
        }

        public static T SetPortraitSpriteReference<T>(this T definition, AssetReferenceSprite value)
            where T : EffectProxyDefinition
        {
            definition.SetField("portraitSpriteReference", value);
            return definition;
        }

        public static T SetPrefabReference<T>(this T definition, AssetReference value)
            where T : EffectProxyDefinition
        {
            definition.SetField("prefabReference", value);
            return definition;
        }

        public static T SetShowWorldLocationFeedbacks<T>(this T definition, bool value)
            where T : EffectProxyDefinition
        {
            definition.SetField("showWorldLocationFeedbacks", value);
            return definition;
        }

        public static T SetSoundEffectOnHitDescription<T>(this T definition, SoundEffectOnHitDescription value)
            where T : EffectProxyDefinition
        {
            definition.SetField("soundEffectOnHitDescription", value);
            return definition;
        }
    }
}