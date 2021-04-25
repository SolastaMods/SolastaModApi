using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine.AddressableAssets;
using System;
using TA.AI;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;
using static BestiaryDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MonsterDefinitionExtensions
    {
        public static void SetAbilityScores(this MonsterDefinition definition, Int32[] value)
        {
            definition.SetField("abilityScores", value);
        }

        public static void SetAlignment(this MonsterDefinition definition, String value)
        {
            definition.SetField("alignment", value);
        }

        public static void SetArmor(this MonsterDefinition definition, String value)
        {
            definition.SetField("armor", value);
        }

        public static void SetArmorClass(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("armorClass", value);
        }

        public static void SetAttackIterations(this MonsterDefinition definition, List<MonsterAttackIteration> value)
        {
            definition.SetField("attackIterations", value);
        }

        public static void SetAudioRaceRTPCValue(this MonsterDefinition definition, Single value)
        {
            definition.SetField("audioRaceRTPCValue", value);
        }

        public static void SetAudioSwitches(this MonsterDefinition definition, List<Switch> value)
        {
            definition.SetField("audioSwitches", value);
        }

        public static void SetBestiaryEntry(this MonsterDefinition definition, BestiaryEntry value)
        {
            definition.SetField("bestiaryEntry", value);
        }

        public static void SetBestiaryLootOptions(this MonsterDefinition definition, List<ItemDefinition> value)
        {
            definition.SetField("bestiaryLootOptions", value);
        }

        public static void SetBestiaryReference(this MonsterDefinition definition, MonsterDefinition value)
        {
            definition.SetField("bestiaryReference", value);
        }

        public static void SetBestiarySpriteReference(this MonsterDefinition definition, AssetReferenceSprite value)
        {
            definition.SetField("bestiarySpriteReference", value);
        }

        public static void SetChallengeRating(this MonsterDefinition definition, Single value)
        {
            definition.SetField("challengeRating", value);
        }

        public static void SetCharacterFamily(this MonsterDefinition definition, String value)
        {
            definition.SetField("characterFamily", value);
        }

        public static void SetCreatureTags(this MonsterDefinition definition, List<String> value)
        {
            definition.SetField("creatureTags", value);
        }

        public static void SetDefaultBattleDecisionPackage(this MonsterDefinition definition, DecisionPackageDefinition value)
        {
            definition.SetField("defaultBattleDecisionPackage", value);
        }

        public static void SetDefaultFaction(this MonsterDefinition definition, String value)
        {
            definition.SetField("defaultFaction", value);
        }

        public static void SetDifferentActionEachTurn(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("differentActionEachTurn", value);
        }

        public static void SetDroppedLootDefinition(this MonsterDefinition definition, LootPackDefinition value)
        {
            definition.SetField("droppedLootDefinition", value);
        }

        public static void SetDualSex(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("dualSex", value);
        }

        public static void SetFeatures(this MonsterDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
        }

        public static void SetFollowFloorAngle(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("followFloorAngle", value);
        }

        public static void SetForceCombatStartsAnimation(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("forceCombatStartsAnimation", value);
        }

        public static void SetForcePersistentBody(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("forcePersistentBody", value);
        }

        public static void SetFullyControlledWhenAllied(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("fullyControlledWhenAllied", value);
        }

        public static void SetHeight(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("height", value);
        }

        public static void SetHitDice(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("hitDice", value);
        }

        public static void SetHitDiceType(this MonsterDefinition definition, DieType value)
        {
            definition.SetField("hitDiceType", value);
        }

        public static void SetHitPointsBonus(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("hitPointsBonus", value);
        }

        public static void SetInDungeonEditor(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("inDungeonEditor", value);
        }

        public static void SetInterceptStance(this MonsterDefinition definition, MoveStance value)
        {
            definition.SetField("interceptStance", value);
        }

        public static void SetIsHusk(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("isHusk", value);
        }

        public static void SetLanguages(this MonsterDefinition definition, List<String> value)
        {
            definition.SetField("languages", value);
        }

        public static void SetLegendaryActionOptions(this MonsterDefinition definition, List<LegendaryActionDescription> value)
        {
            definition.SetField("legendaryActionOptions", value);
        }

        public static void SetLegendaryCreature(this MonsterDefinition definition, Boolean value)
        {
            definition.SetField("legendaryCreature", value);
        }

        public static void SetMaximalAge(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("maximalAge", value);
        }

        public static void SetMaxLegendaryActionPoints(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("maxLegendaryActionPoints", value);
        }

        public static void SetMaxLegendaryResistances(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("maxLegendaryResistances", value);
        }

        public static void SetMinimalAge(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("minimalAge", value);
        }

        public static void SetMonsterPresentation(this MonsterDefinition definition, MonsterPresentation value)
        {
            definition.SetField("monsterPresentation", value);
        }

        public static void SetPatrolStance(this MonsterDefinition definition, MoveStance value)
        {
            definition.SetField("patrolStance", value);
        }

        public static void SetSavingThrowScores(this MonsterDefinition definition, List<MonsterSavingThrowProficiency> value)
        {
            definition.SetField("savingThrowScores", value);
        }

        public static void SetSkillScores(this MonsterDefinition definition, List<MonsterSkillProficiency> value)
        {
            definition.SetField("skillScores", value);
        }

        public static void SetSneakStance(this MonsterDefinition definition, MoveStance value)
        {
            definition.SetField("sneakStance", value);
        }

        public static void SetStandardHitPoints(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("standardHitPoints", value);
        }

        public static void SetStealableLootDefinition(this MonsterDefinition definition, LootPackDefinition value)
        {
            definition.SetField("stealableLootDefinition", value);
        }

        public static void SetThreatEvaluatorDefinition(this MonsterDefinition definition, ThreatEvaluatorDefinition value)
        {
            definition.SetField("threatEvaluatorDefinition", value);
        }

        public static void SetWeight(this MonsterDefinition definition, Int32 value)
        {
            definition.SetField("weight", value);
        }
    }
}