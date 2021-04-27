using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class CharacterTemplateDefinitionExtensions
    {
        public static T SetAbilityScores<T>(this T definition, int[] value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("abilityScores", value);
            return definition;
        }

        public static T SetAge<T>(this T definition, int value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("age", value);
            return definition;
        }

        public static T SetAgeMorphotypeValue<T>(this T definition, float value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("ageMorphotypeValue", value);
            return definition;
        }

        public static T SetAlignment<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("alignment", value);
            return definition;
        }

        public static T SetAlignmentPersonalityFlag1<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("alignmentPersonalityFlag1", value);
            return definition;
        }

        public static T SetAlignmentPersonalityFlag2<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("alignmentPersonalityFlag2", value);
            return definition;
        }

        public static T SetAutomateAbilityScoreIncreases<T>(this T definition, bool value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("automateAbilityScoreIncreases", value);
            return definition;
        }

        public static T SetBackground<T>(this T definition, CharacterBackgroundDefinition value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("background", value);
            return definition;
        }

        public static T SetBackgroundPersonalityFlag1<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("backgroundPersonalityFlag1", value);
            return definition;
        }

        public static T SetBackgroundPersonalityFlag2<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("backgroundPersonalityFlag2", value);
            return definition;
        }

        public static T SetBeardShapeMorphotype<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("beardShapeMorphotype", value);
            return definition;
        }

        public static T SetBodyDecorationMorphotype<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("bodyDecorationMorphotype", value);
            return definition;
        }

        public static T SetCharacterLevel<T>(this T definition, int value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("characterLevel", value);
            return definition;
        }

        public static T SetDeity<T>(this T definition, DeityDefinition value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("deity", value);
            return definition;
        }

        public static T SetEditorOnly<T>(this T definition, bool value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("editorOnly", value);
            return definition;
        }

        public static T SetEyeColorMorphotype<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("eyeColorMorphotype", value);
            return definition;
        }

        public static T SetFacePath<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("facePath", value);
            return definition;
        }

        public static T SetFaceShapeMorphotype<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("faceShapeMorphotype", value);
            return definition;
        }

        public static T SetFightingStyle<T>(this T definition, FightingStyleDefinition value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("fightingStyle", value);
            return definition;
        }

        public static T SetFirstName<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("firstName", value);
            return definition;
        }

        public static T SetHairColorMorphotype<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("hairColorMorphotype", value);
            return definition;
        }

        public static T SetHairShapeMorphotype<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("hairShapeMorphotype", value);
            return definition;
        }

        public static T SetMainClass<T>(this T definition, CharacterClassDefinition value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("mainClass", value);
            return definition;
        }

        public static T SetMainRace<T>(this T definition, CharacterRaceDefinition value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("mainRace", value);
            return definition;
        }

        public static T SetMusculatureMorphotypeValue<T>(this T definition, float value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("musculatureMorphotypeValue", value);
            return definition;
        }

        public static T SetOriginMorphotype<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("originMorphotype", value);
            return definition;
        }

        public static T SetSex<T>(this T definition, CreatureSex value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("sex", value);
            return definition;
        }

        public static T SetSkinMorphotype<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("skinMorphotype", value);
            return definition;
        }

        public static T SetStartingMoney<T>(this T definition, int[] value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("startingMoney", value);
            return definition;
        }

        public static T SetSubClass<T>(this T definition, CharacterSubclassDefinition value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("subClass", value);
            return definition;
        }

        public static T SetSubRace<T>(this T definition, CharacterRaceDefinition value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("subRace", value);
            return definition;
        }

        public static T SetSurName<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("surName", value);
            return definition;
        }

        public static T SetVoiceId<T>(this T definition, string value)
            where T : CharacterTemplateDefinition
        {
            definition.SetField("voiceId", value);
            return definition;
        }
    }
}