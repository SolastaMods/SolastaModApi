using SolastaModApi.Infrastructure;
using AK.Wwise;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class VoiceDefinitionExtensions
    {
        public static VoiceDefinition SetAmplitude(this VoiceDefinition definition, float value)
        {
            definition.SetField("amplitude", value);
            return definition;
        }

        public static VoiceDefinition SetAvailableInCharacterCreation(this VoiceDefinition definition, bool value)
        {
            definition.SetField("availableInCharacterCreation", value);
            return definition;
        }

        public static VoiceDefinition SetIndividualName(this VoiceDefinition definition, string value)
        {
            definition.SetField("individualName", value);
            return definition;
        }

        public static VoiceDefinition SetSex(this VoiceDefinition definition, CreatureSex value)
        {
            definition.SetField("sex", value);
            return definition;
        }

        public static VoiceDefinition SetSpeechSpeed(this VoiceDefinition definition, float value)
        {
            definition.SetField("speechSpeed", value);
            return definition;
        }

        public static VoiceDefinition SetWavePath(this VoiceDefinition definition, string value)
        {
            definition.SetField("wavePath", value);
            return definition;
        }

        public static VoiceDefinition SetWavePrefix(this VoiceDefinition definition, string value)
        {
            definition.SetField("wavePrefix", value);
            return definition;
        }

        public static VoiceDefinition SetWavFilesPath(this VoiceDefinition definition, Dictionary<string, string> value)
        {
            definition.SetField("wavFilesPath", value);
            return definition;
        }

        public static VoiceDefinition SetWwiseSuffix(this VoiceDefinition definition, string value)
        {
            definition.SetField("wwiseSuffix", value);
            return definition;
        }

        public static VoiceDefinition SetWwiseSwitch(this VoiceDefinition definition, Switch value)
        {
            definition.SetField("wwiseSwitch", value);
            return definition;
        }
    }
}