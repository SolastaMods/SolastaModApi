using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static ActionDefinitions;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi
{
    public static class MonsterAttackDefinitionExtensions
    {
        public static T SetActionType<T>(this T definition, ActionType value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("actionType", value);
            return definition;
        }

        public static T SetAfterChargeOnly<T>(this T definition, bool value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("afterChargeOnly", value);
            return definition;
        }

        public static T SetAnimationTag<T>(this T definition, string value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("animationTag", value);
            return definition;
        }

        public static T SetChargeEndParticle<T>(this T definition, AssetReference value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("chargeEndParticle", value);
            return definition;
        }

        public static T SetChargeLoopParticle<T>(this T definition, AssetReference value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("chargeLoopParticle", value);
            return definition;
        }

        public static T SetChargePrepareParticle<T>(this T definition, AssetReference value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("chargePrepareParticle", value);
            return definition;
        }

        public static T SetChargeStartParticle<T>(this T definition, AssetReference value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("chargeStartParticle", value);
            return definition;
        }

        public static T SetCloseRange<T>(this T definition, int value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("closeRange", value);
            return definition;
        }

        public static T SetDisplayedInEditor<T>(this T definition, bool value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("displayedInEditor", value);
            return definition;
        }

        public static T SetEffectDescription<T>(this T definition, EffectDescription value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("effectDescription", value);
            return definition;
        }

        public static T SetItemDefinitionMainHand<T>(this T definition, ItemDefinition value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("itemDefinitionMainHand", value);
            return definition;
        }

        public static T SetItemDefinitionOffHand<T>(this T definition, ItemDefinition value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("itemDefinitionOffHand", value);
            return definition;
        }

        public static T SetLimitedUse<T>(this T definition, bool value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("limitedUse", value);
            return definition;
        }

        public static T SetMaxRange<T>(this T definition, int value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("maxRange", value);
            return definition;
        }

        public static T SetMaxUses<T>(this T definition, int value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("maxUses", value);
            return definition;
        }

        public static T SetMethodName<T>(this T definition, string value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("methodName", value);
            return definition;
        }

        public static T SetProjectile<T>(this T definition, string value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("projectile", value);
            return definition;
        }

        public static T SetProjectileBone<T>(this T definition, BoneType value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("projectileBone", value);
            return definition;
        }

        public static T SetProximity<T>(this T definition, AttackProximity value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("proximity", value);
            return definition;
        }

        public static T SetReachRange<T>(this T definition, int value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("reachRange", value);
            return definition;
        }

        public static T SetSoundEffectOnHitDescription<T>(this T definition, SoundEffectOnHitDescription value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("soundEffectOnHitDescription", value);
            return definition;
        }

        public static T SetToHitBonus<T>(this T definition, int value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("toHitBonus", value);
            return definition;
        }

        public static T SetUseAnimationTag<T>(this T definition, bool value)
            where T : MonsterAttackDefinition
        {
            definition.SetField("useAnimationTag", value);
            return definition;
        }
    }
}