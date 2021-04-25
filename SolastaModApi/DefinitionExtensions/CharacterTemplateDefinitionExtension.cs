using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterTemplateDefinitionExtensions
    {
        public static CharacterTemplateDefinition SetAbilityScores(this CharacterTemplateDefinition definition, int[] value)
        {
            definition.SetField("abilityScores", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetAge(this CharacterTemplateDefinition definition, int value)
        {
            definition.SetField("age", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetAgeMorphotypeValue(this CharacterTemplateDefinition definition, float value)
        {
            definition.SetField("ageMorphotypeValue", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetAlignment(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("alignment", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetAlignmentPersonalityFlag1(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("alignmentPersonalityFlag1", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetAlignmentPersonalityFlag2(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("alignmentPersonalityFlag2", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetAutomateAbilityScoreIncreases(this CharacterTemplateDefinition definition, bool value)
        {
            definition.SetField("automateAbilityScoreIncreases", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetBackground(this CharacterTemplateDefinition definition, CharacterBackgroundDefinition value)
        {
            definition.SetField("background", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetBackgroundPersonalityFlag1(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("backgroundPersonalityFlag1", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetBackgroundPersonalityFlag2(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("backgroundPersonalityFlag2", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetBeardShapeMorphotype(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("beardShapeMorphotype", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetBodyDecorationMorphotype(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("bodyDecorationMorphotype", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetCharacterLevel(this CharacterTemplateDefinition definition, int value)
        {
            definition.SetField("characterLevel", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetDeity(this CharacterTemplateDefinition definition, DeityDefinition value)
        {
            definition.SetField("deity", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetEditorOnly(this CharacterTemplateDefinition definition, bool value)
        {
            definition.SetField("editorOnly", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetEquipment(this CharacterTemplateDefinition definition, List<ItemDefinition> value)
        {
            definition.SetField("equipment", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetExpertisesOverride(this CharacterTemplateDefinition definition, List<string> value)
        {
            definition.SetField("expertisesOverride", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetEyeColorMorphotype(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("eyeColorMorphotype", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetFacePath(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("facePath", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetFaceShapeMorphotype(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("faceShapeMorphotype", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetFeatsOverride(this CharacterTemplateDefinition definition, List<string> value)
        {
            definition.SetField("featsOverride", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetFightingStyle(this CharacterTemplateDefinition definition, FightingStyleDefinition value)
        {
            definition.SetField("fightingStyle", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetFirstName(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("firstName", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetHairColorMorphotype(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("hairColorMorphotype", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetHairShapeMorphotype(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("hairShapeMorphotype", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetKnownClassCantrips(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownClassCantrips", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetKnownClassSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownClassSpells", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetKnownRaceCantrips(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownRaceCantrips", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetKnownRaceSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownRaceSpells", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetKnownSubclassCantrips(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownSubclassCantrips", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetKnownSubclassSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("knownSubclassSpells", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetLanguagesOverride(this CharacterTemplateDefinition definition, List<string> value)
        {
            definition.SetField("languagesOverride", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetMainClass(this CharacterTemplateDefinition definition, CharacterClassDefinition value)
        {
            definition.SetField("mainClass", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetMainRace(this CharacterTemplateDefinition definition, CharacterRaceDefinition value)
        {
            definition.SetField("mainRace", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetMusculatureMorphotypeValue(this CharacterTemplateDefinition definition, float value)
        {
            definition.SetField("musculatureMorphotypeValue", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetOriginMorphotype(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("originMorphotype", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetPreparedClassSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("preparedClassSpells", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetPreparedSubclassSpells(this CharacterTemplateDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("preparedSubclassSpells", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetSex(this CharacterTemplateDefinition definition, CreatureSex value)
        {
            definition.SetField("sex", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetSkillsOverride(this CharacterTemplateDefinition definition, List<string> value)
        {
            definition.SetField("skillsOverride", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetSkinMorphotype(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("skinMorphotype", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetStartingMoney(this CharacterTemplateDefinition definition, int[] value)
        {
            definition.SetField("startingMoney", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetSubClass(this CharacterTemplateDefinition definition, CharacterSubclassDefinition value)
        {
            definition.SetField("subClass", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetSubRace(this CharacterTemplateDefinition definition, CharacterRaceDefinition value)
        {
            definition.SetField("subRace", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetSurName(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("surName", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetToolsOverride(this CharacterTemplateDefinition definition, List<string> value)
        {
            definition.SetField("toolsOverride", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetVoiceId(this CharacterTemplateDefinition definition, string value)
        {
            definition.SetField("voiceId", value);
            return definition;
        }

        public static CharacterTemplateDefinition SetWieldedItemsConfigurations(this CharacterTemplateDefinition definition, List<WieldedItemsConfiguration> value)
        {
            definition.SetField("wieldedItemsConfigurations", value);
            return definition;
        }
    }
}