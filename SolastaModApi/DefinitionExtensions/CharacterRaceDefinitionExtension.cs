using SolastaModApi.Infrastructure;
using AK.Wwise;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterRaceDefinitionExtensions
    {
        public static void SetAudioRaceRTPCValue(this CharacterRaceDefinition definition, Single value)
        {
            definition.SetField("audioRaceRTPCValue", value);
        }

        public static void SetAudioSwitches(this CharacterRaceDefinition definition, List<Switch> value)
        {
            definition.SetField("audioSwitches", value);
        }

        public static void SetBaseHeight(this CharacterRaceDefinition definition, Int32 value)
        {
            definition.SetField("baseHeight", value);
        }

        public static void SetBaseWeight(this CharacterRaceDefinition definition, Int32 value)
        {
            definition.SetField("baseWeight", value);
        }

        public static void SetDefaultAlignement(this CharacterRaceDefinition definition, String value)
        {
            definition.SetField("defaultAlignement", value);
        }

        public static void SetDualSex(this CharacterRaceDefinition definition, Boolean value)
        {
            definition.SetField("dualSex", value);
        }

        public static void SetFeatureUnlocks(this CharacterRaceDefinition definition, List<FeatureUnlockByLevel> value)
        {
            definition.SetField("featureUnlocks", value);
        }

        public static void SetInventoryDefinition(this CharacterRaceDefinition definition, InventoryDefinition value)
        {
            definition.SetField("inventoryDefinition", value);
        }

        public static void SetLanguageAutolearnPreference(this CharacterRaceDefinition definition, List<String> value)
        {
            definition.SetField("languageAutolearnPreference", value);
        }

        public static void SetMaximalAge(this CharacterRaceDefinition definition, Int32 value)
        {
            definition.SetField("maximalAge", value);
        }

        public static void SetMinimalAge(this CharacterRaceDefinition definition, Int32 value)
        {
            definition.SetField("minimalAge", value);
        }

        public static void SetPersonalityFlagOccurences(this CharacterRaceDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
        }

        public static void SetRacePresentation(this CharacterRaceDefinition definition, RacePresentation value)
        {
            definition.SetField("racePresentation", value);
        }

        public static void SetSubRaces(this CharacterRaceDefinition definition, List<CharacterRaceDefinition> value)
        {
            definition.SetField("subRaces", value);
        }
    }
}