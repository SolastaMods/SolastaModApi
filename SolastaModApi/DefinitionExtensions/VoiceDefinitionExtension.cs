using SolastaModApi.Infrastructure;
using AK.Wwise;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class VoiceDefinitionExtensions
    {
        public static void SetAmplitude(this VoiceDefinition definition, Single value)
        {
            definition.SetField("amplitude", value);
        }

        public static void SetAvailableInCharacterCreation(this VoiceDefinition definition, Boolean value)
        {
            definition.SetField("availableInCharacterCreation", value);
        }

        public static void SetIndividualName(this VoiceDefinition definition, String value)
        {
            definition.SetField("individualName", value);
        }

        public static void SetSex(this VoiceDefinition definition, CreatureSex value)
        {
            definition.SetField("sex", value);
        }

        public static void SetSpeechSpeed(this VoiceDefinition definition, Single value)
        {
            definition.SetField("speechSpeed", value);
        }

        public static void SetWavePath(this VoiceDefinition definition, String value)
        {
            definition.SetField("wavePath", value);
        }

        public static void SetWavePrefix(this VoiceDefinition definition, String value)
        {
            definition.SetField("wavePrefix", value);
        }

        public static void SetWavFilesPath(this VoiceDefinition definition, Dictionary<String, String> value)
        {
            definition.SetField("wavFilesPath", value);
        }

        public static void SetWwiseSuffix(this VoiceDefinition definition, String value)
        {
            definition.SetField("wwiseSuffix", value);
        }

        public static void SetWwiseSwitch(this VoiceDefinition definition, Switch value)
        {
            definition.SetField("wwiseSwitch", value);
        }
    }
}