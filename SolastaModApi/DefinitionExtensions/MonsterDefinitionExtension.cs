using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine.AddressableAssets;
using TA.AI;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;
using static BestiaryDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MonsterDefinitionExtensions
    {
        public static MonsterDefinition SetAbilityScores(this MonsterDefinition definition, int[] value)
        {
            definition.SetField("abilityScores", value);
            return definition;
        }

        public static MonsterDefinition SetAlignment(this MonsterDefinition definition, string value)
        {
            definition.SetField("alignment", value);
            return definition;
        }

        public static MonsterDefinition SetArmor(this MonsterDefinition definition, string value)
        {
            definition.SetField("armor", value);
            return definition;
        }

        public static MonsterDefinition SetArmorClass(this MonsterDefinition definition, int value)
        {
            definition.SetField("armorClass", value);
            return definition;
        }

        public static MonsterDefinition SetAttackIterations(this MonsterDefinition definition, List<MonsterAttackIteration> value)
        {
            definition.SetField("attackIterations", value);
            return definition;
        }

        public static MonsterDefinition SetAudioRaceRTPCValue(this MonsterDefinition definition, float value)
        {
            definition.SetField("audioRaceRTPCValue", value);
            return definition;
        }

        public static MonsterDefinition SetAudioSwitches(this MonsterDefinition definition, List<Switch> value)
        {
            definition.SetField("audioSwitches", value);
            return definition;
        }

        public static MonsterDefinition SetBestiaryEntry(this MonsterDefinition definition, BestiaryEntry value)
        {
            definition.SetField("bestiaryEntry", value);
            return definition;
        }

        public static MonsterDefinition SetBestiaryLootOptions(this MonsterDefinition definition, List<ItemDefinition> value)
        {
            definition.SetField("bestiaryLootOptions", value);
            return definition;
        }

        public static MonsterDefinition SetBestiaryReference(this MonsterDefinition definition, MonsterDefinition value)
        {
            definition.SetField("bestiaryReference", value);
            return definition;
        }

        public static MonsterDefinition SetBestiarySpriteReference(this MonsterDefinition definition, AssetReferenceSprite value)
        {
            definition.SetField("bestiarySpriteReference", value);
            return definition;
        }

        public static MonsterDefinition SetChallengeRating(this MonsterDefinition definition, float value)
        {
            definition.SetField("challengeRating", value);
            return definition;
        }

        public static MonsterDefinition SetCharacterFamily(this MonsterDefinition definition, string value)
        {
            definition.SetField("characterFamily", value);
            return definition;
        }

        public static MonsterDefinition SetCreatureTags(this MonsterDefinition definition, List<string> value)
        {
            definition.SetField("creatureTags", value);
            return definition;
        }

        public static MonsterDefinition SetDefaultBattleDecisionPackage(this MonsterDefinition definition, DecisionPackageDefinition value)
        {
            definition.SetField("defaultBattleDecisionPackage", value);
            return definition;
        }

        public static MonsterDefinition SetDefaultFaction(this MonsterDefinition definition, string value)
        {
            definition.SetField("defaultFaction", value);
            return definition;
        }

        public static MonsterDefinition SetDifferentActionEachTurn(this MonsterDefinition definition, bool value)
        {
            definition.SetField("differentActionEachTurn", value);
            return definition;
        }

        public static MonsterDefinition SetDroppedLootDefinition(this MonsterDefinition definition, LootPackDefinition value)
        {
            definition.SetField("droppedLootDefinition", value);
            return definition;
        }

        public static MonsterDefinition SetDualSex(this MonsterDefinition definition, bool value)
        {
            definition.SetField("dualSex", value);
            return definition;
        }

        public static MonsterDefinition SetFeatures(this MonsterDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
            return definition;
        }

        public static MonsterDefinition SetFollowFloorAngle(this MonsterDefinition definition, bool value)
        {
            definition.SetField("followFloorAngle", value);
            return definition;
        }

        public static MonsterDefinition SetForceCombatStartsAnimation(this MonsterDefinition definition, bool value)
        {
            definition.SetField("forceCombatStartsAnimation", value);
            return definition;
        }

        public static MonsterDefinition SetForcePersistentBody(this MonsterDefinition definition, bool value)
        {
            definition.SetField("forcePersistentBody", value);
            return definition;
        }

        public static MonsterDefinition SetFullyControlledWhenAllied(this MonsterDefinition definition, bool value)
        {
            definition.SetField("fullyControlledWhenAllied", value);
            return definition;
        }

        public static MonsterDefinition SetHeight(this MonsterDefinition definition, int value)
        {
            definition.SetField("height", value);
            return definition;
        }

        public static MonsterDefinition SetHitDice(this MonsterDefinition definition, int value)
        {
            definition.SetField("hitDice", value);
            return definition;
        }

        public static MonsterDefinition SetHitDiceType(this MonsterDefinition definition, DieType value)
        {
            definition.SetField("hitDiceType", value);
            return definition;
        }

        public static MonsterDefinition SetHitPointsBonus(this MonsterDefinition definition, int value)
        {
            definition.SetField("hitPointsBonus", value);
            return definition;
        }

        public static MonsterDefinition SetInDungeonEditor(this MonsterDefinition definition, bool value)
        {
            definition.SetField("inDungeonEditor", value);
            return definition;
        }

        public static MonsterDefinition SetInterceptStance(this MonsterDefinition definition, MoveStance value)
        {
            definition.SetField("interceptStance", value);
            return definition;
        }

        public static MonsterDefinition SetIsHusk(this MonsterDefinition definition, bool value)
        {
            definition.SetField("isHusk", value);
            return definition;
        }

        public static MonsterDefinition SetLanguages(this MonsterDefinition definition, List<string> value)
        {
            definition.SetField("languages", value);
            return definition;
        }

        public static MonsterDefinition SetLegendaryActionOptions(this MonsterDefinition definition, List<LegendaryActionDescription> value)
        {
            definition.SetField("legendaryActionOptions", value);
            return definition;
        }

        public static MonsterDefinition SetLegendaryCreature(this MonsterDefinition definition, bool value)
        {
            definition.SetField("legendaryCreature", value);
            return definition;
        }

        public static MonsterDefinition SetMaximalAge(this MonsterDefinition definition, int value)
        {
            definition.SetField("maximalAge", value);
            return definition;
        }

        public static MonsterDefinition SetMaxLegendaryActionPoints(this MonsterDefinition definition, int value)
        {
            definition.SetField("maxLegendaryActionPoints", value);
            return definition;
        }

        public static MonsterDefinition SetMaxLegendaryResistances(this MonsterDefinition definition, int value)
        {
            definition.SetField("maxLegendaryResistances", value);
            return definition;
        }

        public static MonsterDefinition SetMinimalAge(this MonsterDefinition definition, int value)
        {
            definition.SetField("minimalAge", value);
            return definition;
        }

        public static MonsterDefinition SetMonsterPresentation(this MonsterDefinition definition, MonsterPresentation value)
        {
            definition.SetField("monsterPresentation", value);
            return definition;
        }

        public static MonsterDefinition SetPatrolStance(this MonsterDefinition definition, MoveStance value)
        {
            definition.SetField("patrolStance", value);
            return definition;
        }

        public static MonsterDefinition SetSavingThrowScores(this MonsterDefinition definition, List<MonsterSavingThrowProficiency> value)
        {
            definition.SetField("savingThrowScores", value);
            return definition;
        }

        public static MonsterDefinition SetSkillScores(this MonsterDefinition definition, List<MonsterSkillProficiency> value)
        {
            definition.SetField("skillScores", value);
            return definition;
        }

        public static MonsterDefinition SetSneakStance(this MonsterDefinition definition, MoveStance value)
        {
            definition.SetField("sneakStance", value);
            return definition;
        }

        public static MonsterDefinition SetStandardHitPoints(this MonsterDefinition definition, int value)
        {
            definition.SetField("standardHitPoints", value);
            return definition;
        }

        public static MonsterDefinition SetStealableLootDefinition(this MonsterDefinition definition, LootPackDefinition value)
        {
            definition.SetField("stealableLootDefinition", value);
            return definition;
        }

        public static MonsterDefinition SetThreatEvaluatorDefinition(this MonsterDefinition definition, ThreatEvaluatorDefinition value)
        {
            definition.SetField("threatEvaluatorDefinition", value);
            return definition;
        }

        public static MonsterDefinition SetWeight(this MonsterDefinition definition, int value)
        {
            definition.SetField("weight", value);
            return definition;
        }
    }
}