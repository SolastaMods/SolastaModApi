using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static ActionDefinitions;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MonsterAttackDefinitionExtensions
    {
        public static MonsterAttackDefinition SetActionType(this MonsterAttackDefinition definition, ActionType value)
        {
            definition.SetField("actionType", value);
            return definition;
        }

        public static MonsterAttackDefinition SetAfterChargeOnly(this MonsterAttackDefinition definition, bool value)
        {
            definition.SetField("afterChargeOnly", value);
            return definition;
        }

        public static MonsterAttackDefinition SetAnimationTag(this MonsterAttackDefinition definition, string value)
        {
            definition.SetField("animationTag", value);
            return definition;
        }

        public static MonsterAttackDefinition SetChargeEndParticle(this MonsterAttackDefinition definition, AssetReference value)
        {
            definition.SetField("chargeEndParticle", value);
            return definition;
        }

        public static MonsterAttackDefinition SetChargeLoopParticle(this MonsterAttackDefinition definition, AssetReference value)
        {
            definition.SetField("chargeLoopParticle", value);
            return definition;
        }

        public static MonsterAttackDefinition SetChargePrepareParticle(this MonsterAttackDefinition definition, AssetReference value)
        {
            definition.SetField("chargePrepareParticle", value);
            return definition;
        }

        public static MonsterAttackDefinition SetChargeStartParticle(this MonsterAttackDefinition definition, AssetReference value)
        {
            definition.SetField("chargeStartParticle", value);
            return definition;
        }

        public static MonsterAttackDefinition SetCloseRange(this MonsterAttackDefinition definition, int value)
        {
            definition.SetField("closeRange", value);
            return definition;
        }

        public static MonsterAttackDefinition SetDisplayedInEditor(this MonsterAttackDefinition definition, bool value)
        {
            definition.SetField("displayedInEditor", value);
            return definition;
        }

        public static MonsterAttackDefinition SetEffectDescription(this MonsterAttackDefinition definition, EffectDescription value)
        {
            definition.SetField("effectDescription", value);
            return definition;
        }

        public static MonsterAttackDefinition SetItemDefinitionMainHand(this MonsterAttackDefinition definition, ItemDefinition value)
        {
            definition.SetField("itemDefinitionMainHand", value);
            return definition;
        }

        public static MonsterAttackDefinition SetItemDefinitionOffHand(this MonsterAttackDefinition definition, ItemDefinition value)
        {
            definition.SetField("itemDefinitionOffHand", value);
            return definition;
        }

        public static MonsterAttackDefinition SetLimitedUse(this MonsterAttackDefinition definition, bool value)
        {
            definition.SetField("limitedUse", value);
            return definition;
        }

        public static MonsterAttackDefinition SetMaxRange(this MonsterAttackDefinition definition, int value)
        {
            definition.SetField("maxRange", value);
            return definition;
        }

        public static MonsterAttackDefinition SetMaxUses(this MonsterAttackDefinition definition, int value)
        {
            definition.SetField("maxUses", value);
            return definition;
        }

        public static MonsterAttackDefinition SetMethodName(this MonsterAttackDefinition definition, string value)
        {
            definition.SetField("methodName", value);
            return definition;
        }

        public static MonsterAttackDefinition SetProjectile(this MonsterAttackDefinition definition, string value)
        {
            definition.SetField("projectile", value);
            return definition;
        }

        public static MonsterAttackDefinition SetProjectileBone(this MonsterAttackDefinition definition, BoneType value)
        {
            definition.SetField("projectileBone", value);
            return definition;
        }

        public static MonsterAttackDefinition SetProximity(this MonsterAttackDefinition definition, AttackProximity value)
        {
            definition.SetField("proximity", value);
            return definition;
        }

        public static MonsterAttackDefinition SetReachRange(this MonsterAttackDefinition definition, int value)
        {
            definition.SetField("reachRange", value);
            return definition;
        }

        public static MonsterAttackDefinition SetSoundEffectOnHitDescription(this MonsterAttackDefinition definition, SoundEffectOnHitDescription value)
        {
            definition.SetField("soundEffectOnHitDescription", value);
            return definition;
        }

        public static MonsterAttackDefinition SetToHitBonus(this MonsterAttackDefinition definition, int value)
        {
            definition.SetField("toHitBonus", value);
            return definition;
        }

        public static MonsterAttackDefinition SetUseAnimationTag(this MonsterAttackDefinition definition, bool value)
        {
            definition.SetField("useAnimationTag", value);
            return definition;
        }
    }
}