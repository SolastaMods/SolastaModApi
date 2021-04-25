using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterTemplateDefinitionExtensions
    {
        public static void SetAbilityScores(this CharacterTemplateDefinition definition, Int32[] value)
        {
            definition.SetField("abilityScores", value);
        }

        public static void SetAge(this CharacterTemplateDefinition definition, Int32 value)
        {
            definition.SetField("age", value);
        }

        public static void SetAgeMorphotypeValue(this CharacterTemplateDefinition definition, Single value)
        {
            definition.SetField("ageMorphotypeValue", value);
        }

        public static void SetAlignment(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("alignment", value);
        }

        public static void SetAlignmentPersonalityFlag1(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("alignmentPersonalityFlag1", value);
        }

        public static void SetAlignmentPersonalityFlag2(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("alignmentPersonalityFlag2", value);
        }

        public static void SetAutomateAbilityScoreIncreases(this CharacterTemplateDefinition definition, Boolean value)
        {
            definition.SetField("automateAbilityScoreIncreases", value);
        }

        public static void SetBackground(this CharacterTemplateDefinition definition, CharacterBackgroundDefinition value)
        {
            definition.SetField("background", value);
        }

        public static void SetBackgroundPersonalityFlag1(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("backgroundPersonalityFlag1", value);
        }

        public static void SetBackgroundPersonalityFlag2(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("backgroundPersonalityFlag2", value);
        }

        public static void SetBeardShapeMorphotype(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("beardShapeMorphotype", value);
        }

        public static void SetBodyDecorationMorphotype(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("bodyDecorationMorphotype", value);
        }

        public static void SetCharacterLevel(this CharacterTemplateDefinition definition, Int32 value)
        {
            definition.SetField("characterLevel", value);
        }

        public static void SetDeity(this CharacterTemplateDefinition definition, DeityDefinition value)
        {
            definition.SetField("deity", value);
        }

        public static void SetEditorOnly(this CharacterTemplateDefinition definition, Boolean value)
        {
            definition.SetField("editorOnly", value);
        }

        public static void SetEquipment(this CharacterTemplateDefinition definition, List<ItemDefinition> value)
        {
            definition.SetField("equipment", value);
        }

        public static void SetExpertisesOverride(this CharacterTemplateDefinition definition, List<String> value)
        {
            definition.SetField("expertisesOverride", value);
        }

        public static void SetEyeColorMorphotype(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("eyeColorMorphotype", value);
        }

        public static void SetFacePath(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("facePath", value);
        }

        public static void SetFaceShapeMorphotype(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("faceShapeMorphotype", value);
        }

        public static void SetFeatsOverride(this CharacterTemplateDefinition definition, List<String> value)
        {
            definition.SetField("featsOverride", value);
        }

        public static void SetFightingStyle(this CharacterTemplateDefinition definition, FightingStyleDefinition value)
        {
            definition.SetField("fightingStyle", value);
        }

        public static void SetFirstName(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("firstName", value);
        }

        public static void SetHairColorMorphotype(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("hairColorMorphotype", value);
        }

        public static void SetHairShapeMorphotype(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("hairShapeMorphotype", value);
        }

        public static void SetKnownClassCantrips(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownClassCantrips", value);
        }

        public static void SetKnownClassSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownClassSpells", value);
        }

        public static void SetKnownRaceCantrips(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownRaceCantrips", value);
        }

        public static void SetKnownRaceSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownRaceSpells", value);
        }

        public static void SetKnownSubclassCantrips(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownSubclassCantrips", value);
        }

        public static void SetKnownSubclassSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownSubclassSpells", value);
        }

        public static void SetLanguagesOverride(this CharacterTemplateDefinition definition, List<String> value)
        {
            definition.SetField("languagesOverride", value);
        }

        public static void SetMainClass(this CharacterTemplateDefinition definition, CharacterClassDefinition value)
        {
            definition.SetField("mainClass", value);
        }

        public static void SetMainRace(this CharacterTemplateDefinition definition, CharacterRaceDefinition value)
        {
            definition.SetField("mainRace", value);
        }

        public static void SetMusculatureMorphotypeValue(this CharacterTemplateDefinition definition, Single value)
        {
            definition.SetField("musculatureMorphotypeValue", value);
        }

        public static void SetOriginMorphotype(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("originMorphotype", value);
        }

        public static void SetPreparedClassSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("preparedClassSpells", value);
        }

        public static void SetPreparedSubclassSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("preparedSubclassSpells", value);
        }

        public static void SetSex(this CharacterTemplateDefinition definition, CreatureSex value)
        {
            definition.SetField("sex", value);
        }

        public static void SetSkillsOverride(this CharacterTemplateDefinition definition, List<String> value)
        {
            definition.SetField("skillsOverride", value);
        }

        public static void SetSkinMorphotype(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("skinMorphotype", value);
        }

        public static void SetStartingMoney(this CharacterTemplateDefinition definition, Int32[] value)
        {
            definition.SetField("startingMoney", value);
        }

        public static void SetSubClass(this CharacterTemplateDefinition definition, CharacterSubclassDefinition value)
        {
            definition.SetField("subClass", value);
        }

        public static void SetSubRace(this CharacterTemplateDefinition definition, CharacterRaceDefinition value)
        {
            definition.SetField("subRace", value);
        }

        public static void SetSurName(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("surName", value);
        }

        public static void SetToolsOverride(this CharacterTemplateDefinition definition, List<String> value)
        {
            definition.SetField("toolsOverride", value);
        }

        public static void SetVoiceId(this CharacterTemplateDefinition definition, String value)
        {
            definition.SetField("voiceId", value);
        }

        public static void SetWieldedItemsConfigurations(this CharacterTemplateDefinition definition, List<WieldedItemsConfiguration> value)
        {
            definition.SetField("wieldedItemsConfigurations", value);
        }
    }
}