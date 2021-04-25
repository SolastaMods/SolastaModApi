using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System;
using static ActionDefinitions;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MonsterAttackDefinitionExtensions
    {
        public static void SetActionType(this MonsterAttackDefinition definition, ActionType value)
        {
            definition.SetField("actionType", value);
        }

        public static void SetAfterChargeOnly(this MonsterAttackDefinition definition, Boolean value)
        {
            definition.SetField("afterChargeOnly", value);
        }

        public static void SetAnimationTag(this MonsterAttackDefinition definition, String value)
        {
            definition.SetField("animationTag", value);
        }

        public static void SetChargeEndParticle(this MonsterAttackDefinition definition, AssetReference value)
        {
            definition.SetField("chargeEndParticle", value);
        }

        public static void SetChargeLoopParticle(this MonsterAttackDefinition definition, AssetReference value)
        {
            definition.SetField("chargeLoopParticle", value);
        }

        public static void SetChargePrepareParticle(this MonsterAttackDefinition definition, AssetReference value)
        {
            definition.SetField("chargePrepareParticle", value);
        }

        public static void SetChargeStartParticle(this MonsterAttackDefinition definition, AssetReference value)
        {
            definition.SetField("chargeStartParticle", value);
        }

        public static void SetCloseRange(this MonsterAttackDefinition definition, Int32 value)
        {
            definition.SetField("closeRange", value);
        }

        public static void SetDisplayedInEditor(this MonsterAttackDefinition definition, Boolean value)
        {
            definition.SetField("displayedInEditor", value);
        }

        public static void SetEffectDescription(this MonsterAttackDefinition definition, EffectDescription value)
        {
            definition.SetField("effectDescription", value);
        }

        public static void SetItemDefinitionMainHand(this MonsterAttackDefinition definition, ItemDefinition value)
        {
            definition.SetField("itemDefinitionMainHand", value);
        }

        public static void SetItemDefinitionOffHand(this MonsterAttackDefinition definition, ItemDefinition value)
        {
            definition.SetField("itemDefinitionOffHand", value);
        }

        public static void SetLimitedUse(this MonsterAttackDefinition definition, Boolean value)
        {
            definition.SetField("limitedUse", value);
        }

        public static void SetMaxRange(this MonsterAttackDefinition definition, Int32 value)
        {
            definition.SetField("maxRange", value);
        }

        public static void SetMaxUses(this MonsterAttackDefinition definition, Int32 value)
        {
            definition.SetField("maxUses", value);
        }

        public static void SetMethodName(this MonsterAttackDefinition definition, String value)
        {
            definition.SetField("methodName", value);
        }

        public static void SetProjectile(this MonsterAttackDefinition definition, String value)
        {
            definition.SetField("projectile", value);
        }

        public static void SetProjectileBone(this MonsterAttackDefinition definition, BoneType value)
        {
            definition.SetField("projectileBone", value);
        }

        public static void SetProximity(this MonsterAttackDefinition definition, AttackProximity value)
        {
            definition.SetField("proximity", value);
        }

        public static void SetReachRange(this MonsterAttackDefinition definition, Int32 value)
        {
            definition.SetField("reachRange", value);
        }

        public static void SetSoundEffectOnHitDescription(this MonsterAttackDefinition definition, SoundEffectOnHitDescription value)
        {
            definition.SetField("soundEffectOnHitDescription", value);
        }

        public static void SetToHitBonus(this MonsterAttackDefinition definition, Int32 value)
        {
            definition.SetField("toHitBonus", value);
        }

        public static void SetUseAnimationTag(this MonsterAttackDefinition definition, Boolean value)
        {
            definition.SetField("useAnimationTag", value);
        }
    }
}