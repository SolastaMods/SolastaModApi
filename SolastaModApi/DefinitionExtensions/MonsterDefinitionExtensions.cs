using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine.AddressableAssets;
using TA.AI;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;
using static BestiaryDefinitions;

namespace SolastaModApi
{
    public static class MonsterDefinitionExtensions
    {
        public static T SetAbilityScores<T>(this T definition, int[] value)
            where T : MonsterDefinition
        {
            definition.SetField("abilityScores", value);
            return definition;
        }

        public static T SetAlignment<T>(this T definition, string value)
            where T : MonsterDefinition
        {
            definition.SetField("alignment", value);
            return definition;
        }

        public static T SetArmor<T>(this T definition, string value)
            where T : MonsterDefinition
        {
            definition.SetField("armor", value);
            return definition;
        }

        public static T SetArmorClass<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("armorClass", value);
            return definition;
        }

        public static T SetAttackIterations<T>(this T definition, List<MonsterAttackIteration> value)
            where T : MonsterDefinition
        {
            definition.SetField("attackIterations", value);
            return definition;
        }

        public static T SetAudioRaceRTPCValue<T>(this T definition, float value)
            where T : MonsterDefinition
        {
            definition.SetField("audioRaceRTPCValue", value);
            return definition;
        }

        public static T SetAudioSwitches<T>(this T definition, List<Switch> value)
            where T : MonsterDefinition
        {
            definition.SetField("audioSwitches", value);
            return definition;
        }

        public static T SetBestiaryEntry<T>(this T definition, BestiaryEntry value)
            where T : MonsterDefinition
        {
            definition.SetField("bestiaryEntry", value);
            return definition;
        }

        public static T SetBestiaryLootOptions<T>(this T definition, List<ItemDefinition> value)
            where T : MonsterDefinition
        {
            definition.SetField("bestiaryLootOptions", value);
            return definition;
        }

        public static T SetBestiaryReference<T>(this T definition, MonsterDefinition value)
            where T : MonsterDefinition
        {
            definition.SetField("bestiaryReference", value);
            return definition;
        }

        public static T SetBestiarySpriteReference<T>(this T definition, AssetReferenceSprite value)
            where T : MonsterDefinition
        {
            definition.SetField("bestiarySpriteReference", value);
            return definition;
        }

        public static T SetChallengeRating<T>(this T definition, float value)
            where T : MonsterDefinition
        {
            definition.SetField("challengeRating", value);
            return definition;
        }

        public static T SetCharacterFamily<T>(this T definition, string value)
            where T : MonsterDefinition
        {
            definition.SetField("characterFamily", value);
            return definition;
        }

        public static T SetCreatureTags<T>(this T definition, List<string> value)
            where T : MonsterDefinition
        {
            definition.SetField("creatureTags", value);
            return definition;
        }

        public static T SetDefaultBattleDecisionPackage<T>(this T definition, DecisionPackageDefinition value)
            where T : MonsterDefinition
        {
            definition.SetField("defaultBattleDecisionPackage", value);
            return definition;
        }

        public static T SetDefaultFaction<T>(this T definition, string value)
            where T : MonsterDefinition
        {
            definition.SetField("defaultFaction", value);
            return definition;
        }

        public static T SetDifferentActionEachTurn<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("differentActionEachTurn", value);
            return definition;
        }

        public static T SetDroppedLootDefinition<T>(this T definition, LootPackDefinition value)
            where T : MonsterDefinition
        {
            definition.SetField("droppedLootDefinition", value);
            return definition;
        }

        public static T SetDualSex<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("dualSex", value);
            return definition;
        }

        public static T SetFeatures<T>(this T definition, List<FeatureDefinition> value)
            where T : MonsterDefinition
        {
            definition.SetField("features", value);
            return definition;
        }

        public static T SetFollowFloorAngle<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("followFloorAngle", value);
            return definition;
        }

        public static T SetForceCombatStartsAnimation<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("forceCombatStartsAnimation", value);
            return definition;
        }

        public static T SetForcePersistentBody<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("forcePersistentBody", value);
            return definition;
        }

        public static T SetFullyControlledWhenAllied<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("fullyControlledWhenAllied", value);
            return definition;
        }

        public static T SetHeight<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("height", value);
            return definition;
        }

        public static T SetHitDice<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("hitDice", value);
            return definition;
        }

        public static T SetHitDiceType<T>(this T definition, DieType value)
            where T : MonsterDefinition
        {
            definition.SetField("hitDiceType", value);
            return definition;
        }

        public static T SetHitPointsBonus<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("hitPointsBonus", value);
            return definition;
        }

        public static T SetInDungeonEditor<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("inDungeonEditor", value);
            return definition;
        }

        public static T SetInterceptStance<T>(this T definition, MoveStance value)
            where T : MonsterDefinition
        {
            definition.SetField("interceptStance", value);
            return definition;
        }

        public static T SetIsHusk<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("isHusk", value);
            return definition;
        }

        public static T SetLanguages<T>(this T definition, List<string> value)
            where T : MonsterDefinition
        {
            definition.SetField("languages", value);
            return definition;
        }

        public static T SetLegendaryActionOptions<T>(this T definition, List<LegendaryActionDescription> value)
            where T : MonsterDefinition
        {
            definition.SetField("legendaryActionOptions", value);
            return definition;
        }

        public static T SetLegendaryCreature<T>(this T definition, bool value)
            where T : MonsterDefinition
        {
            definition.SetField("legendaryCreature", value);
            return definition;
        }

        public static T SetMaximalAge<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("maximalAge", value);
            return definition;
        }

        public static T SetMaxLegendaryActionPoints<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("maxLegendaryActionPoints", value);
            return definition;
        }

        public static T SetMaxLegendaryResistances<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("maxLegendaryResistances", value);
            return definition;
        }

        public static T SetMinimalAge<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("minimalAge", value);
            return definition;
        }

        public static T SetMonsterPresentation<T>(this T definition, MonsterPresentation value)
            where T : MonsterDefinition
        {
            definition.SetField("monsterPresentation", value);
            return definition;
        }

        public static T SetPatrolStance<T>(this T definition, MoveStance value)
            where T : MonsterDefinition
        {
            definition.SetField("patrolStance", value);
            return definition;
        }

        public static T SetSavingThrowScores<T>(this T definition, List<MonsterSavingThrowProficiency> value)
            where T : MonsterDefinition
        {
            definition.SetField("savingThrowScores", value);
            return definition;
        }

        public static T SetSkillScores<T>(this T definition, List<MonsterSkillProficiency> value)
            where T : MonsterDefinition
        {
            definition.SetField("skillScores", value);
            return definition;
        }

        public static T SetSneakStance<T>(this T definition, MoveStance value)
            where T : MonsterDefinition
        {
            definition.SetField("sneakStance", value);
            return definition;
        }

        public static T SetStandardHitPoints<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("standardHitPoints", value);
            return definition;
        }

        public static T SetStealableLootDefinition<T>(this T definition, LootPackDefinition value)
            where T : MonsterDefinition
        {
            definition.SetField("stealableLootDefinition", value);
            return definition;
        }

        public static T SetThreatEvaluatorDefinition<T>(this T definition, ThreatEvaluatorDefinition value)
            where T : MonsterDefinition
        {
            definition.SetField("threatEvaluatorDefinition", value);
            return definition;
        }

        public static T SetWeight<T>(this T definition, int value)
            where T : MonsterDefinition
        {
            definition.SetField("weight", value);
            return definition;
        }
    }
}