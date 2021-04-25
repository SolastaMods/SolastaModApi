using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class WeaponTypeDefinitionExtensions
    {
        public static void SetAnimationTag(this WeaponTypeDefinition definition, String value)
        {
            definition.SetField("animationTag", value);
        }

        public static void SetIsAttachedToBone(this WeaponTypeDefinition definition, BoneType value)
        {
            definition.SetField("isAttachedToBone", value);
        }

        public static void SetIsBow(this WeaponTypeDefinition definition, Boolean value)
        {
            definition.SetField("isBow", value);
        }

        public static void SetMeleeAttackerParticleReference(this WeaponTypeDefinition definition, AssetReference value)
        {
            definition.SetField("meleeAttackerParticleReference", value);
        }

        public static void SetMeleeImpactParticleReference(this WeaponTypeDefinition definition, AssetReference value)
        {
            definition.SetField("meleeImpactParticleReference", value);
        }

        public static void SetSecondaryAnimationTag(this WeaponTypeDefinition definition, String value)
        {
            definition.SetField("secondaryAnimationTag", value);
        }

        public static void SetSoundEffectDescription(this WeaponTypeDefinition definition, SoundEffectDescription value)
        {
            definition.SetField("soundEffectDescription", value);
        }

        public static void SetSoundEffectOnHitDescription(this WeaponTypeDefinition definition, SoundEffectOnHitDescription value)
        {
            definition.SetField("soundEffectOnHitDescription", value);
        }

        public static void SetThrowAttackerParticleReference(this WeaponTypeDefinition definition, AssetReference value)
        {
            definition.SetField("throwAttackerParticleReference", value);
        }

        public static void SetThrowImpactParticleReference(this WeaponTypeDefinition definition, AssetReference value)
        {
            definition.SetField("throwImpactParticleReference", value);
        }

        public static void SetWeaponCategory(this WeaponTypeDefinition definition, String value)
        {
            definition.SetField("weaponCategory", value);
        }

        public static void SetWeaponProximity(this WeaponTypeDefinition definition, AttackProximity value)
        {
            definition.SetField("weaponProximity", value);
        }
    }
}