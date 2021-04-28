using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class CharacterTemplateDefinitionExtensions
    {
        public static T SetAbilityScores<T>(this T entity, int[] value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("abilityScores", value);
            return entity;
        }

        public static T SetAge<T>(this T entity, int value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("age", value);
            return entity;
        }

        public static T SetAgeMorphotypeValue<T>(this T entity, float value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("ageMorphotypeValue", value);
            return entity;
        }

        public static T SetAlignment<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("alignment", value);
            return entity;
        }

        public static T SetAlignmentPersonalityFlag1<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("alignmentPersonalityFlag1", value);
            return entity;
        }

        public static T SetAlignmentPersonalityFlag2<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("alignmentPersonalityFlag2", value);
            return entity;
        }

        public static T SetAutomateAbilityScoreIncreases<T>(this T entity, bool value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("automateAbilityScoreIncreases", value);
            return entity;
        }

        public static T SetBackground<T>(this T entity, CharacterBackgroundDefinition value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("background", value);
            return entity;
        }

        public static T SetBackgroundPersonalityFlag1<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("backgroundPersonalityFlag1", value);
            return entity;
        }

        public static T SetBackgroundPersonalityFlag2<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("backgroundPersonalityFlag2", value);
            return entity;
        }

        public static T SetBeardShapeMorphotype<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("beardShapeMorphotype", value);
            return entity;
        }

        public static T SetBodyDecorationMorphotype<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("bodyDecorationMorphotype", value);
            return entity;
        }

        public static T SetCharacterLevel<T>(this T entity, int value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("characterLevel", value);
            return entity;
        }

        public static T SetDeity<T>(this T entity, DeityDefinition value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("deity", value);
            return entity;
        }

        public static T SetEditorOnly<T>(this T entity, bool value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("editorOnly", value);
            return entity;
        }

        public static T SetEyeColorMorphotype<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("eyeColorMorphotype", value);
            return entity;
        }

        public static T SetFacePath<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("facePath", value);
            return entity;
        }

        public static T SetFaceShapeMorphotype<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("faceShapeMorphotype", value);
            return entity;
        }

        public static T SetFightingStyle<T>(this T entity, FightingStyleDefinition value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("fightingStyle", value);
            return entity;
        }

        public static T SetFirstName<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("firstName", value);
            return entity;
        }

        public static T SetHairColorMorphotype<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("hairColorMorphotype", value);
            return entity;
        }

        public static T SetHairShapeMorphotype<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("hairShapeMorphotype", value);
            return entity;
        }

        public static T SetMainClass<T>(this T entity, CharacterClassDefinition value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("mainClass", value);
            return entity;
        }

        public static T SetMainRace<T>(this T entity, CharacterRaceDefinition value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("mainRace", value);
            return entity;
        }

        public static T SetMusculatureMorphotypeValue<T>(this T entity, float value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("musculatureMorphotypeValue", value);
            return entity;
        }

        public static T SetOriginMorphotype<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("originMorphotype", value);
            return entity;
        }

        public static T SetSex<T>(this T entity, CreatureSex value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("sex", value);
            return entity;
        }

        public static T SetSkinMorphotype<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("skinMorphotype", value);
            return entity;
        }

        public static T SetStartingMoney<T>(this T entity, int[] value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("startingMoney", value);
            return entity;
        }

        public static T SetSubClass<T>(this T entity, CharacterSubclassDefinition value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("subClass", value);
            return entity;
        }

        public static T SetSubRace<T>(this T entity, CharacterRaceDefinition value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("subRace", value);
            return entity;
        }

        public static T SetSurName<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("surName", value);
            return entity;
        }

        public static T SetVoiceId<T>(this T entity, string value)
            where T : CharacterTemplateDefinition
        {
            entity.SetField("voiceId", value);
            return entity;
        }
    }
}