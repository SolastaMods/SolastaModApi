using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DifficultyPresetDefinitionExtensions
    {
        public static void SetAbilityCheckAllyModifier(this DifficultyPresetDefinition definition, Int32 value)
        {
            definition.SetField("abilityCheckAllyModifier", value);
        }

        public static void SetAbilityCheckEnemyModifier(this DifficultyPresetDefinition definition, Int32 value)
        {
            definition.SetField("abilityCheckEnemyModifier", value);
        }

        public static void SetAiTargetsHelplessCharacters(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("aiTargetsHelplessCharacters", value);
        }

        public static void SetAiUsesPowerfulMovesMoreOften(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("aiUsesPowerfulMovesMoreOften", value);
        }

        public static void SetAlwaysDisplayDialogChances(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("alwaysDisplayDialogChances", value);
        }

        public static void SetAttackRollAllyModifier(this DifficultyPresetDefinition definition, Int32 value)
        {
            definition.SetField("attackRollAllyModifier", value);
        }

        public static void SetAttackRollEnemyModifier(this DifficultyPresetDefinition definition, Int32 value)
        {
            definition.SetField("attackRollEnemyModifier", value);
        }

        public static void SetAuthorizeRetryOnGadgets(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("authorizeRetryOnGadgets", value);
        }

        public static void SetAutoDetectTraps(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("autoDetectTraps", value);
        }

        public static void SetAutorevive(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("autorevive", value);
        }

        public static void SetCompanionsRest(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("companionsRest", value);
        }

        public static void SetDamageTakenAllyMultiplier(this DifficultyPresetDefinition definition, Single value)
        {
            definition.SetField("damageTakenAllyMultiplier", value);
        }

        public static void SetDisableEnemyCrits(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("disableEnemyCrits", value);
        }

        public static void SetDisableRandomEncounters(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("disableRandomEncounters", value);
        }

        public static void SetEncumbranceRuleType(this DifficultyPresetDefinition definition, String value)
        {
            definition.SetField("encumbranceRuleType", value);
        }

        public static void SetEnemyHpMultiplier(this DifficultyPresetDefinition definition, Single value)
        {
            definition.SetField("enemyHpMultiplier", value);
        }

        public static void SetForceCraftingRollSuccess(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("forceCraftingRollSuccess", value);
        }

        public static void SetForceCritEveryFewRolls(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("forceCritEveryFewRolls", value);
        }

        public static void SetForceSuccessOnDialogRolls(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("forceSuccessOnDialogRolls", value);
        }

        public static void SetIsDefaultPreset(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("isDefaultPreset", value);
        }

        public static void SetMaterialComponent(this DifficultyPresetDefinition definition, String value)
        {
            definition.SetField("materialComponent", value);
        }

        public static void SetMaxHpOnHitDice(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("maxHpOnHitDice", value);
        }

        public static void SetMaxHpOnLevelUp(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("maxHpOnLevelUp", value);
        }

        public static void SetNeverLoseConcentrationOnSpells(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("neverLoseConcentrationOnSpells", value);
        }

        public static void SetNoFoodNeeded(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("noFoodNeeded", value);
        }

        public static void SetNoToolRequirement(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("noToolRequirement", value);
        }

        public static void SetPresetName(this DifficultyPresetDefinition definition, String value)
        {
            definition.SetField("presetName", value);
        }

        public static void SetRandomnessMode(this DifficultyPresetDefinition definition, String value)
        {
            definition.SetField("randomnessMode", value);
        }

        public static void SetSavingThrowAllyModifier(this DifficultyPresetDefinition definition, Int32 value)
        {
            definition.SetField("savingThrowAllyModifier", value);
        }

        public static void SetSavingThrowEnemyModifier(this DifficultyPresetDefinition definition, Int32 value)
        {
            definition.SetField("savingThrowEnemyModifier", value);
        }

        public static void SetScrollsCanBeUsedByAnyCharacter(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("scrollsCanBeUsedByAnyCharacter", value);
        }

        public static void SetSomaticComponent(this DifficultyPresetDefinition definition, String value)
        {
            definition.SetField("somaticComponent", value);
        }

        public static void SetUnlockAllBestiaryContent(this DifficultyPresetDefinition definition, Boolean value)
        {
            definition.SetField("unlockAllBestiaryContent", value);
        }

        public static void SetVerbalComponent(this DifficultyPresetDefinition definition, String value)
        {
            definition.SetField("verbalComponent", value);
        }
    }
}