using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class WeaponTypeDefinitionExtensions
    {
        public static WeaponTypeDefinition SetAnimationTag(this WeaponTypeDefinition definition, string value)
        {
            definition.SetField("animationTag", value);
            return definition;
        }

        public static WeaponTypeDefinition SetIsAttachedToBone(this WeaponTypeDefinition definition, BoneType value)
        {
            definition.SetField("isAttachedToBone", value);
            return definition;
        }

        public static WeaponTypeDefinition SetIsBow(this WeaponTypeDefinition definition, bool value)
        {
            definition.SetField("isBow", value);
            return definition;
        }

        public static WeaponTypeDefinition SetMeleeAttackerParticleReference(this WeaponTypeDefinition definition, AssetReference value)
        {
            definition.SetField("meleeAttackerParticleReference", value);
            return definition;
        }

        public static WeaponTypeDefinition SetMeleeImpactParticleReference(this WeaponTypeDefinition definition, AssetReference value)
        {
            definition.SetField("meleeImpactParticleReference", value);
            return definition;
        }

        public static WeaponTypeDefinition SetSecondaryAnimationTag(this WeaponTypeDefinition definition, string value)
        {
            definition.SetField("secondaryAnimationTag", value);
            return definition;
        }

        public static WeaponTypeDefinition SetSoundEffectDescription(this WeaponTypeDefinition definition, SoundEffectDescription value)
        {
            definition.SetField("soundEffectDescription", value);
            return definition;
        }

        public static WeaponTypeDefinition SetSoundEffectOnHitDescription(this WeaponTypeDefinition definition, SoundEffectOnHitDescription value)
        {
            definition.SetField("soundEffectOnHitDescription", value);
            return definition;
        }

        public static WeaponTypeDefinition SetThrowAttackerParticleReference(this WeaponTypeDefinition definition, AssetReference value)
        {
            definition.SetField("throwAttackerParticleReference", value);
            return definition;
        }

        public static WeaponTypeDefinition SetThrowImpactParticleReference(this WeaponTypeDefinition definition, AssetReference value)
        {
            definition.SetField("throwImpactParticleReference", value);
            return definition;
        }

        public static WeaponTypeDefinition SetWeaponCategory(this WeaponTypeDefinition definition, string value)
        {
            definition.SetField("weaponCategory", value);
            return definition;
        }

        public static WeaponTypeDefinition SetWeaponProximity(this WeaponTypeDefinition definition, AttackProximity value)
        {
            definition.SetField("weaponProximity", value);
            return definition;
        }
    }
}