using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DifficultyPresetDefinitionExtensions
    {
        public static DifficultyPresetDefinition SetAbilityCheckAllyModifier(this DifficultyPresetDefinition definition, int value)
        {
            definition.SetField("abilityCheckAllyModifier", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAbilityCheckEnemyModifier(this DifficultyPresetDefinition definition, int value)
        {
            definition.SetField("abilityCheckEnemyModifier", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAiTargetsHelplessCharacters(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("aiTargetsHelplessCharacters", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAiUsesPowerfulMovesMoreOften(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("aiUsesPowerfulMovesMoreOften", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAlwaysDisplayDialogChances(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("alwaysDisplayDialogChances", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAttackRollAllyModifier(this DifficultyPresetDefinition definition, int value)
        {
            definition.SetField("attackRollAllyModifier", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAttackRollEnemyModifier(this DifficultyPresetDefinition definition, int value)
        {
            definition.SetField("attackRollEnemyModifier", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAuthorizeRetryOnGadgets(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("authorizeRetryOnGadgets", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAutoDetectTraps(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("autoDetectTraps", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetAutorevive(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("autorevive", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetCompanionsRest(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("companionsRest", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetDamageTakenAllyMultiplier(this DifficultyPresetDefinition definition, float value)
        {
            definition.SetField("damageTakenAllyMultiplier", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetDisableEnemyCrits(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("disableEnemyCrits", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetDisableRandomEncounters(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("disableRandomEncounters", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetEncumbranceRuleType(this DifficultyPresetDefinition definition, string value)
        {
            definition.SetField("encumbranceRuleType", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetEnemyHpMultiplier(this DifficultyPresetDefinition definition, float value)
        {
            definition.SetField("enemyHpMultiplier", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetForceCraftingRollSuccess(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("forceCraftingRollSuccess", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetForceCritEveryFewRolls(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("forceCritEveryFewRolls", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetForceSuccessOnDialogRolls(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("forceSuccessOnDialogRolls", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetIsDefaultPreset(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("isDefaultPreset", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetMaterialComponent(this DifficultyPresetDefinition definition, string value)
        {
            definition.SetField("materialComponent", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetMaxHpOnHitDice(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("maxHpOnHitDice", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetMaxHpOnLevelUp(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("maxHpOnLevelUp", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetNeverLoseConcentrationOnSpells(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("neverLoseConcentrationOnSpells", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetNoFoodNeeded(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("noFoodNeeded", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetNoToolRequirement(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("noToolRequirement", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetPresetName(this DifficultyPresetDefinition definition, string value)
        {
            definition.SetField("presetName", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetRandomnessMode(this DifficultyPresetDefinition definition, string value)
        {
            definition.SetField("randomnessMode", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetSavingThrowAllyModifier(this DifficultyPresetDefinition definition, int value)
        {
            definition.SetField("savingThrowAllyModifier", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetSavingThrowEnemyModifier(this DifficultyPresetDefinition definition, int value)
        {
            definition.SetField("savingThrowEnemyModifier", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetScrollsCanBeUsedByAnyCharacter(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("scrollsCanBeUsedByAnyCharacter", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetSomaticComponent(this DifficultyPresetDefinition definition, string value)
        {
            definition.SetField("somaticComponent", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetUnlockAllBestiaryContent(this DifficultyPresetDefinition definition, bool value)
        {
            definition.SetField("unlockAllBestiaryContent", value);
            return definition;
        }

        public static DifficultyPresetDefinition SetVerbalComponent(this DifficultyPresetDefinition definition, string value)
        {
            definition.SetField("verbalComponent", value);
            return definition;
        }
    }
}