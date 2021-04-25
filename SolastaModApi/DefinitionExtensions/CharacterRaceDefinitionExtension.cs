using SolastaModApi.Infrastructure;
using AK.Wwise;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterRaceDefinitionExtensions
    {
        public static CharacterRaceDefinition SetAudioRaceRTPCValue(this CharacterRaceDefinition definition, float value)
        {
            definition.SetField("audioRaceRTPCValue", value);
            return definition;
        }

        public static CharacterRaceDefinition SetAudioSwitches(this CharacterRaceDefinition definition, List<Switch> value)
        {
            definition.SetField("audioSwitches", value);
            return definition;
        }

        public static CharacterRaceDefinition SetBaseHeight(this CharacterRaceDefinition definition, int value)
        {
            definition.SetField("baseHeight", value);
            return definition;
        }

        public static CharacterRaceDefinition SetBaseWeight(this CharacterRaceDefinition definition, int value)
        {
            definition.SetField("baseWeight", value);
            return definition;
        }

        public static CharacterRaceDefinition SetDefaultAlignement(this CharacterRaceDefinition definition, string value)
        {
            definition.SetField("defaultAlignement", value);
            return definition;
        }

        public static CharacterRaceDefinition SetDualSex(this CharacterRaceDefinition definition, bool value)
        {
            definition.SetField("dualSex", value);
            return definition;
        }

        public static CharacterRaceDefinition SetFeatureUnlocks(this CharacterRaceDefinition definition, List<FeatureUnlockByLevel> value)
        {
            definition.SetField("featureUnlocks", value);
            return definition;
        }

        public static CharacterRaceDefinition SetInventoryDefinition(this CharacterRaceDefinition definition, InventoryDefinition value)
        {
            definition.SetField("inventoryDefinition", value);
            return definition;
        }

        public static CharacterRaceDefinition SetLanguageAutolearnPreference(this CharacterRaceDefinition definition, List<string> value)
        {
            definition.SetField("languageAutolearnPreference", value);
            return definition;
        }

        public static CharacterRaceDefinition SetMaximalAge(this CharacterRaceDefinition definition, int value)
        {
            definition.SetField("maximalAge", value);
            return definition;
        }

        public static CharacterRaceDefinition SetMinimalAge(this CharacterRaceDefinition definition, int value)
        {
            definition.SetField("minimalAge", value);
            return definition;
        }

        public static CharacterRaceDefinition SetPersonalityFlagOccurences(this CharacterRaceDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }

        public static CharacterRaceDefinition SetRacePresentation(this CharacterRaceDefinition definition, RacePresentation value)
        {
            definition.SetField("racePresentation", value);
            return definition;
        }

        public static CharacterRaceDefinition SetSubRaces(this CharacterRaceDefinition definition, List<CharacterRaceDefinition> value)
        {
            definition.SetField("subRaces", value);
            return definition;
        }
    }
}