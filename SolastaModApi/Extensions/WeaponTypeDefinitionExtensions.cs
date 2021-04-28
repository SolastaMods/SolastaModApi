using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi
{
    public static class WeaponTypeDefinitionExtensions
    {
        public static T SetAnimationTag<T>(this T entity, string value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("animationTag", value);
            return entity;
        }

        public static T SetIsAttachedToBone<T>(this T entity, BoneType value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("isAttachedToBone", value);
            return entity;
        }

        public static T SetIsBow<T>(this T entity, bool value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("isBow", value);
            return entity;
        }

        public static T SetMeleeAttackerParticleReference<T>(this T entity, AssetReference value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("meleeAttackerParticleReference", value);
            return entity;
        }

        public static T SetMeleeImpactParticleReference<T>(this T entity, AssetReference value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("meleeImpactParticleReference", value);
            return entity;
        }

        public static T SetSecondaryAnimationTag<T>(this T entity, string value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("secondaryAnimationTag", value);
            return entity;
        }

        public static T SetSoundEffectDescription<T>(this T entity, SoundEffectDescription value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("soundEffectDescription", value);
            return entity;
        }

        public static T SetSoundEffectOnHitDescription<T>(this T entity, SoundEffectOnHitDescription value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("soundEffectOnHitDescription", value);
            return entity;
        }

        public static T SetThrowAttackerParticleReference<T>(this T entity, AssetReference value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("throwAttackerParticleReference", value);
            return entity;
        }

        public static T SetThrowImpactParticleReference<T>(this T entity, AssetReference value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("throwImpactParticleReference", value);
            return entity;
        }

        public static T SetWeaponCategory<T>(this T entity, string value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("weaponCategory", value);
            return entity;
        }

        public static T SetWeaponProximity<T>(this T entity, AttackProximity value)
            where T : WeaponTypeDefinition
        {
            entity.SetField("weaponProximity", value);
            return entity;
        }
    }
}