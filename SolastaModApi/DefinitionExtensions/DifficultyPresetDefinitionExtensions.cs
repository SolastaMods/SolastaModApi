using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DifficultyPresetDefinitionExtensions
    {
        public static T SetAbilityCheckAllyModifier<T>(this T definition, int value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("abilityCheckAllyModifier", value);
            return definition;
        }

        public static T SetAbilityCheckEnemyModifier<T>(this T definition, int value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("abilityCheckEnemyModifier", value);
            return definition;
        }

        public static T SetAiTargetsHelplessCharacters<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("aiTargetsHelplessCharacters", value);
            return definition;
        }

        public static T SetAiUsesPowerfulMovesMoreOften<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("aiUsesPowerfulMovesMoreOften", value);
            return definition;
        }

        public static T SetAlwaysDisplayDialogChances<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("alwaysDisplayDialogChances", value);
            return definition;
        }

        public static T SetAttackRollAllyModifier<T>(this T definition, int value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("attackRollAllyModifier", value);
            return definition;
        }

        public static T SetAttackRollEnemyModifier<T>(this T definition, int value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("attackRollEnemyModifier", value);
            return definition;
        }

        public static T SetAuthorizeRetryOnGadgets<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("authorizeRetryOnGadgets", value);
            return definition;
        }

        public static T SetAutoDetectTraps<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("autoDetectTraps", value);
            return definition;
        }

        public static T SetAutorevive<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("autorevive", value);
            return definition;
        }

        public static T SetCompanionsRest<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("companionsRest", value);
            return definition;
        }

        public static T SetDamageTakenAllyMultiplier<T>(this T definition, float value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("damageTakenAllyMultiplier", value);
            return definition;
        }

        public static T SetDisableEnemyCrits<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("disableEnemyCrits", value);
            return definition;
        }

        public static T SetDisableRandomEncounters<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("disableRandomEncounters", value);
            return definition;
        }

        public static T SetEncumbranceRuleType<T>(this T definition, string value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("encumbranceRuleType", value);
            return definition;
        }

        public static T SetEnemyHpMultiplier<T>(this T definition, float value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("enemyHpMultiplier", value);
            return definition;
        }

        public static T SetForceCraftingRollSuccess<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("forceCraftingRollSuccess", value);
            return definition;
        }

        public static T SetForceCritEveryFewRolls<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("forceCritEveryFewRolls", value);
            return definition;
        }

        public static T SetForceSuccessOnDialogRolls<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("forceSuccessOnDialogRolls", value);
            return definition;
        }

        public static T SetIsDefaultPreset<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("isDefaultPreset", value);
            return definition;
        }

        public static T SetMaterialComponent<T>(this T definition, string value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("materialComponent", value);
            return definition;
        }

        public static T SetMaxHpOnHitDice<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("maxHpOnHitDice", value);
            return definition;
        }

        public static T SetMaxHpOnLevelUp<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("maxHpOnLevelUp", value);
            return definition;
        }

        public static T SetNeverLoseConcentrationOnSpells<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("neverLoseConcentrationOnSpells", value);
            return definition;
        }

        public static T SetNoFoodNeeded<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("noFoodNeeded", value);
            return definition;
        }

        public static T SetNoToolRequirement<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("noToolRequirement", value);
            return definition;
        }

        public static T SetPresetName<T>(this T definition, string value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("presetName", value);
            return definition;
        }

        public static T SetRandomnessMode<T>(this T definition, string value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("randomnessMode", value);
            return definition;
        }

        public static T SetSavingThrowAllyModifier<T>(this T definition, int value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("savingThrowAllyModifier", value);
            return definition;
        }

        public static T SetSavingThrowEnemyModifier<T>(this T definition, int value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("savingThrowEnemyModifier", value);
            return definition;
        }

        public static T SetScrollsCanBeUsedByAnyCharacter<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("scrollsCanBeUsedByAnyCharacter", value);
            return definition;
        }

        public static T SetSomaticComponent<T>(this T definition, string value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("somaticComponent", value);
            return definition;
        }

        public static T SetUnlockAllBestiaryContent<T>(this T definition, bool value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("unlockAllBestiaryContent", value);
            return definition;
        }

        public static T SetVerbalComponent<T>(this T definition, string value)
            where T : DifficultyPresetDefinition
        {
            definition.SetField("verbalComponent", value);
            return definition;
        }
    }
}