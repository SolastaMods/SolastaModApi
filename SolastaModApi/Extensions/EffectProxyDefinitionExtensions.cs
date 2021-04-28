using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class EffectProxyDefinitionExtensions
    {
        public static T SetAddLightSource<T>(this T entity, bool value)
            where T : EffectProxyDefinition
        {
            entity.SetField("addLightSource", value);
            return entity;
        }

        public static T SetAttackImpactParticle<T>(this T entity, AssetReference value)
            where T : EffectProxyDefinition
        {
            entity.SetField("attackImpactParticle", value);
            return entity;
        }

        public static T SetAttackMethod<T>(this T entity, ProxyAttackMethod value)
            where T : EffectProxyDefinition
        {
            entity.SetField("attackMethod", value);
            return entity;
        }

        public static T SetAttackParticle<T>(this T entity, AssetReference value)
            where T : EffectProxyDefinition
        {
            entity.SetField("attackParticle", value);
            return entity;
        }

        public static T SetCanAttack<T>(this T entity, bool value)
            where T : EffectProxyDefinition
        {
            entity.SetField("canAttack", value);
            return entity;
        }

        public static T SetCanMove<T>(this T entity, bool value)
            where T : EffectProxyDefinition
        {
            entity.SetField("canMove", value);
            return entity;
        }

        public static T SetDamageDie<T>(this T entity, DieType value)
            where T : EffectProxyDefinition
        {
            entity.SetField("damageDie", value);
            return entity;
        }

        public static T SetDamageType<T>(this T entity, string value)
            where T : EffectProxyDefinition
        {
            entity.SetField("damageType", value);
            return entity;
        }

        public static T SetHasPortrait<T>(this T entity, bool value)
            where T : EffectProxyDefinition
        {
            entity.SetField("hasPortrait", value);
            return entity;
        }

        public static T SetHasPresentation<T>(this T entity, bool value)
            where T : EffectProxyDefinition
        {
            entity.SetField("hasPresentation", value);
            return entity;
        }

        public static T SetImpactsPlacement<T>(this T entity, bool value)
            where T : EffectProxyDefinition
        {
            entity.SetField("impactsPlacement", value);
            return entity;
        }

        public static T SetIsEmptyPresentation<T>(this T entity, bool value)
            where T : EffectProxyDefinition
        {
            entity.SetField("isEmptyPresentation", value);
            return entity;
        }

        public static T SetLightSourceForm<T>(this T entity, LightSourceForm value)
            where T : EffectProxyDefinition
        {
            entity.SetField("lightSourceForm", value);
            return entity;
        }

        public static T SetModelScale<T>(this T entity, float value)
            where T : EffectProxyDefinition
        {
            entity.SetField("modelScale", value);
            return entity;
        }

        public static T SetPortraitSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : EffectProxyDefinition
        {
            entity.SetField("portraitSpriteReference", value);
            return entity;
        }

        public static T SetPrefabReference<T>(this T entity, AssetReference value)
            where T : EffectProxyDefinition
        {
            entity.SetField("prefabReference", value);
            return entity;
        }

        public static T SetShowWorldLocationFeedbacks<T>(this T entity, bool value)
            where T : EffectProxyDefinition
        {
            entity.SetField("showWorldLocationFeedbacks", value);
            return entity;
        }

        public static T SetSoundEffectOnHitDescription<T>(this T entity, SoundEffectOnHitDescription value)
            where T : EffectProxyDefinition
        {
            entity.SetField("soundEffectOnHitDescription", value);
            return entity;
        }
    }
}