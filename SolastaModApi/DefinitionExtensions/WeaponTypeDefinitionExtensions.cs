using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi
{
    public static class WeaponTypeDefinitionExtensions
    {
        public static T SetAnimationTag<T>(this T definition, string value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("animationTag", value);
            return definition;
        }

        public static T SetIsAttachedToBone<T>(this T definition, BoneType value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("isAttachedToBone", value);
            return definition;
        }

        public static T SetIsBow<T>(this T definition, bool value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("isBow", value);
            return definition;
        }

        public static T SetMeleeAttackerParticleReference<T>(this T definition, AssetReference value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("meleeAttackerParticleReference", value);
            return definition;
        }

        public static T SetMeleeImpactParticleReference<T>(this T definition, AssetReference value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("meleeImpactParticleReference", value);
            return definition;
        }

        public static T SetSecondaryAnimationTag<T>(this T definition, string value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("secondaryAnimationTag", value);
            return definition;
        }

        public static T SetSoundEffectDescription<T>(this T definition, SoundEffectDescription value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("soundEffectDescription", value);
            return definition;
        }

        public static T SetSoundEffectOnHitDescription<T>(this T definition, SoundEffectOnHitDescription value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("soundEffectOnHitDescription", value);
            return definition;
        }

        public static T SetThrowAttackerParticleReference<T>(this T definition, AssetReference value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("throwAttackerParticleReference", value);
            return definition;
        }

        public static T SetThrowImpactParticleReference<T>(this T definition, AssetReference value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("throwImpactParticleReference", value);
            return definition;
        }

        public static T SetWeaponCategory<T>(this T definition, string value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("weaponCategory", value);
            return definition;
        }

        public static T SetWeaponProximity<T>(this T definition, AttackProximity value)
            where T : WeaponTypeDefinition
        {
            definition.SetField("weaponProximity", value);
            return definition;
        }
    }
}