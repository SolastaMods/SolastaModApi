using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using TA.AI;
using static ActionDefinitions;
using static RuleDefinitions;
using static BestiaryDefinitions;

namespace SolastaModApi
{
    public static class MonsterDefinitionExtensions
    {
        public static T SetAbilityScores<T>(this T entity, int[] value)
            where T : MonsterDefinition
        {
            entity.SetField("abilityScores", value);
            return entity;
        }

        public static T SetAlignment<T>(this T entity, string value)
            where T : MonsterDefinition
        {
            entity.SetField("alignment", value);
            return entity;
        }

        public static T SetArmor<T>(this T entity, string value)
            where T : MonsterDefinition
        {
            entity.SetField("armor", value);
            return entity;
        }

        public static T SetArmorClass<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("armorClass", value);
            return entity;
        }

        public static T SetAudioRaceRTPCValue<T>(this T entity, float value)
            where T : MonsterDefinition
        {
            entity.SetField("audioRaceRTPCValue", value);
            return entity;
        }

        public static T SetBestiaryEntry<T>(this T entity, BestiaryEntry value)
            where T : MonsterDefinition
        {
            entity.SetField("bestiaryEntry", value);
            return entity;
        }

        public static T SetBestiaryReference<T>(this T entity, MonsterDefinition value)
            where T : MonsterDefinition
        {
            entity.SetField("bestiaryReference", value);
            return entity;
        }

        public static T SetBestiarySpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : MonsterDefinition
        {
            entity.SetField("bestiarySpriteReference", value);
            return entity;
        }

        public static T SetChallengeRating<T>(this T entity, float value)
            where T : MonsterDefinition
        {
            entity.SetField("challengeRating", value);
            return entity;
        }

        public static T SetCharacterFamily<T>(this T entity, string value)
            where T : MonsterDefinition
        {
            entity.SetField("characterFamily", value);
            return entity;
        }

        public static T SetDefaultBattleDecisionPackage<T>(this T entity, DecisionPackageDefinition value)
            where T : MonsterDefinition
        {
            entity.SetField("defaultBattleDecisionPackage", value);
            return entity;
        }

        public static T SetDefaultFaction<T>(this T entity, string value)
            where T : MonsterDefinition
        {
            entity.SetField("defaultFaction", value);
            return entity;
        }

        public static T SetDifferentActionEachTurn<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("differentActionEachTurn", value);
            return entity;
        }

        public static T SetDroppedLootDefinition<T>(this T entity, LootPackDefinition value)
            where T : MonsterDefinition
        {
            entity.SetField("droppedLootDefinition", value);
            return entity;
        }

        public static T SetDualSex<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("dualSex", value);
            return entity;
        }

        public static T SetFollowFloorAngle<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("followFloorAngle", value);
            return entity;
        }

        public static T SetForceCombatStartsAnimation<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("forceCombatStartsAnimation", value);
            return entity;
        }

        public static T SetForcePersistentBody<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("forcePersistentBody", value);
            return entity;
        }

        public static T SetFullyControlledWhenAllied<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("fullyControlledWhenAllied", value);
            return entity;
        }

        public static T SetHeight<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("height", value);
            return entity;
        }

        public static T SetHitDice<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("hitDice", value);
            return entity;
        }

        public static T SetHitDiceType<T>(this T entity, DieType value)
            where T : MonsterDefinition
        {
            entity.SetField("hitDiceType", value);
            return entity;
        }

        public static T SetHitPointsBonus<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("hitPointsBonus", value);
            return entity;
        }

        public static T SetInDungeonEditor<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("inDungeonEditor", value);
            return entity;
        }

        public static T SetInterceptStance<T>(this T entity, MoveStance value)
            where T : MonsterDefinition
        {
            entity.SetField("interceptStance", value);
            return entity;
        }

        public static T SetIsHusk<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("isHusk", value);
            return entity;
        }

        public static T SetLegendaryCreature<T>(this T entity, bool value)
            where T : MonsterDefinition
        {
            entity.SetField("legendaryCreature", value);
            return entity;
        }

        public static T SetMaximalAge<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("maximalAge", value);
            return entity;
        }

        public static T SetMaxLegendaryActionPoints<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("maxLegendaryActionPoints", value);
            return entity;
        }

        public static T SetMaxLegendaryResistances<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("maxLegendaryResistances", value);
            return entity;
        }

        public static T SetMinimalAge<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("minimalAge", value);
            return entity;
        }

        public static T SetMonsterPresentation<T>(this T entity, MonsterPresentation value)
            where T : MonsterDefinition
        {
            entity.SetField("monsterPresentation", value);
            return entity;
        }

        public static T SetPatrolStance<T>(this T entity, MoveStance value)
            where T : MonsterDefinition
        {
            entity.SetField("patrolStance", value);
            return entity;
        }

        public static T SetSneakStance<T>(this T entity, MoveStance value)
            where T : MonsterDefinition
        {
            entity.SetField("sneakStance", value);
            return entity;
        }

        public static T SetStandardHitPoints<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("standardHitPoints", value);
            return entity;
        }

        public static T SetStealableLootDefinition<T>(this T entity, LootPackDefinition value)
            where T : MonsterDefinition
        {
            entity.SetField("stealableLootDefinition", value);
            return entity;
        }

        public static T SetThreatEvaluatorDefinition<T>(this T entity, ThreatEvaluatorDefinition value)
            where T : MonsterDefinition
        {
            entity.SetField("threatEvaluatorDefinition", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, int value)
            where T : MonsterDefinition
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}