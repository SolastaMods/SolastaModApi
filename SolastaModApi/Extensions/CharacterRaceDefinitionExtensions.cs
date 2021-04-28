using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class CharacterRaceDefinitionExtensions
    {
        public static T SetAudioRaceRTPCValue<T>(this T entity, float value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("audioRaceRTPCValue", value);
            return entity;
        }

        public static T SetBaseHeight<T>(this T entity, int value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("baseHeight", value);
            return entity;
        }

        public static T SetBaseWeight<T>(this T entity, int value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("baseWeight", value);
            return entity;
        }

        public static T SetDefaultAlignement<T>(this T entity, string value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("defaultAlignement", value);
            return entity;
        }

        public static T SetDualSex<T>(this T entity, bool value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("dualSex", value);
            return entity;
        }

        public static T SetInventoryDefinition<T>(this T entity, InventoryDefinition value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("inventoryDefinition", value);
            return entity;
        }

        public static T SetMaximalAge<T>(this T entity, int value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("maximalAge", value);
            return entity;
        }

        public static T SetMinimalAge<T>(this T entity, int value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("minimalAge", value);
            return entity;
        }

        public static T SetRacePresentation<T>(this T entity, RacePresentation value)
            where T : CharacterRaceDefinition
        {
            entity.SetField("racePresentation", value);
            return entity;
        }
    }
}