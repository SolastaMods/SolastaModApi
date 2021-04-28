using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static ActionDefinitions;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi
{
    public static class MonsterAttackDefinitionExtensions
    {
        public static T SetActionType<T>(this T entity, ActionType value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("actionType", value);
            return entity;
        }

        public static T SetAfterChargeOnly<T>(this T entity, bool value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("afterChargeOnly", value);
            return entity;
        }

        public static T SetAnimationTag<T>(this T entity, string value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("animationTag", value);
            return entity;
        }

        public static T SetChargeEndParticle<T>(this T entity, AssetReference value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("chargeEndParticle", value);
            return entity;
        }

        public static T SetChargeLoopParticle<T>(this T entity, AssetReference value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("chargeLoopParticle", value);
            return entity;
        }

        public static T SetChargePrepareParticle<T>(this T entity, AssetReference value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("chargePrepareParticle", value);
            return entity;
        }

        public static T SetChargeStartParticle<T>(this T entity, AssetReference value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("chargeStartParticle", value);
            return entity;
        }

        public static T SetCloseRange<T>(this T entity, int value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("closeRange", value);
            return entity;
        }

        public static T SetDisplayedInEditor<T>(this T entity, bool value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("displayedInEditor", value);
            return entity;
        }

        public static T SetEffectDescription<T>(this T entity, EffectDescription value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("effectDescription", value);
            return entity;
        }

        public static T SetItemDefinitionMainHand<T>(this T entity, ItemDefinition value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("itemDefinitionMainHand", value);
            return entity;
        }

        public static T SetItemDefinitionOffHand<T>(this T entity, ItemDefinition value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("itemDefinitionOffHand", value);
            return entity;
        }

        public static T SetLimitedUse<T>(this T entity, bool value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("limitedUse", value);
            return entity;
        }

        public static T SetMaxRange<T>(this T entity, int value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("maxRange", value);
            return entity;
        }

        public static T SetMaxUses<T>(this T entity, int value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("maxUses", value);
            return entity;
        }

        public static T SetMethodName<T>(this T entity, string value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("methodName", value);
            return entity;
        }

        public static T SetProjectile<T>(this T entity, string value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("projectile", value);
            return entity;
        }

        public static T SetProjectileBone<T>(this T entity, BoneType value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("projectileBone", value);
            return entity;
        }

        public static T SetProximity<T>(this T entity, AttackProximity value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("proximity", value);
            return entity;
        }

        public static T SetReachRange<T>(this T entity, int value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("reachRange", value);
            return entity;
        }

        public static T SetSoundEffectOnHitDescription<T>(this T entity, SoundEffectOnHitDescription value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("soundEffectOnHitDescription", value);
            return entity;
        }

        public static T SetToHitBonus<T>(this T entity, int value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("toHitBonus", value);
            return entity;
        }

        public static T SetUseAnimationTag<T>(this T entity, bool value)
            where T : MonsterAttackDefinition
        {
            entity.SetField("useAnimationTag", value);
            return entity;
        }
    }
}