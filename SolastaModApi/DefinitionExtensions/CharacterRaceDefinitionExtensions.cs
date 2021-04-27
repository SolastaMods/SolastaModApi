using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class CharacterRaceDefinitionExtensions
    {
        public static T SetAudioRaceRTPCValue<T>(this T definition, float value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("audioRaceRTPCValue", value);
            return definition;
        }

        public static T SetBaseHeight<T>(this T definition, int value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("baseHeight", value);
            return definition;
        }

        public static T SetBaseWeight<T>(this T definition, int value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("baseWeight", value);
            return definition;
        }

        public static T SetDefaultAlignement<T>(this T definition, string value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("defaultAlignement", value);
            return definition;
        }

        public static T SetDualSex<T>(this T definition, bool value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("dualSex", value);
            return definition;
        }

        public static T SetInventoryDefinition<T>(this T definition, InventoryDefinition value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("inventoryDefinition", value);
            return definition;
        }

        public static T SetMaximalAge<T>(this T definition, int value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("maximalAge", value);
            return definition;
        }

        public static T SetMinimalAge<T>(this T definition, int value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("minimalAge", value);
            return definition;
        }

        public static T SetRacePresentation<T>(this T definition, RacePresentation value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("racePresentation", value);
            return definition;
        }
    }
}