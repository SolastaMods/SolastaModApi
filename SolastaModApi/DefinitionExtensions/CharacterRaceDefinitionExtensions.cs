using SolastaModApi.Infrastructure;
using AK.Wwise;
using System.Collections.Generic;

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

        public static T SetAudioSwitches<T>(this T definition, List<Switch> value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("audioSwitches", value);
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

        public static T SetFeatureUnlocks<T>(this T definition, List<FeatureUnlockByLevel> value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("featureUnlocks", value);
            return definition;
        }

        public static T SetInventoryDefinition<T>(this T definition, InventoryDefinition value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("inventoryDefinition", value);
            return definition;
        }

        public static T SetLanguageAutolearnPreference<T>(this T definition, List<string> value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("languageAutolearnPreference", value);
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

        public static T SetPersonalityFlagOccurences<T>(this T definition, List<PersonalityFlagOccurence> value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }

        public static T SetRacePresentation<T>(this T definition, RacePresentation value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("racePresentation", value);
            return definition;
        }

        public static T SetSubRaces<T>(this T definition, List<CharacterRaceDefinition> value)
            where T : CharacterRaceDefinition
        {
            definition.SetField("subRaces", value);
            return definition;
        }
    }
}