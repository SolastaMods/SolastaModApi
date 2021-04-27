using SolastaModApi.Infrastructure;
using AK.Wwise;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class VoiceDefinitionExtensions
    {
        public static T SetAmplitude<T>(this T definition, float value)
            where T : VoiceDefinition
        {
            definition.SetField("amplitude", value);
            return definition;
        }

        public static T SetAvailableInCharacterCreation<T>(this T definition, bool value)
            where T : VoiceDefinition
        {
            definition.SetField("availableInCharacterCreation", value);
            return definition;
        }

        public static T SetIndividualName<T>(this T definition, string value)
            where T : VoiceDefinition
        {
            definition.SetField("individualName", value);
            return definition;
        }

        public static T SetSex<T>(this T definition, CreatureSex value)
            where T : VoiceDefinition
        {
            definition.SetField("sex", value);
            return definition;
        }

        public static T SetSpeechSpeed<T>(this T definition, float value)
            where T : VoiceDefinition
        {
            definition.SetField("speechSpeed", value);
            return definition;
        }

        public static T SetWavePath<T>(this T definition, string value)
            where T : VoiceDefinition
        {
            definition.SetField("wavePath", value);
            return definition;
        }

        public static T SetWavePrefix<T>(this T definition, string value)
            where T : VoiceDefinition
        {
            definition.SetField("wavePrefix", value);
            return definition;
        }

        public static T SetWwiseSuffix<T>(this T definition, string value)
            where T : VoiceDefinition
        {
            definition.SetField("wwiseSuffix", value);
            return definition;
        }

        public static T SetWwiseSwitch<T>(this T definition, Switch value)
            where T : VoiceDefinition
        {
            definition.SetField("wwiseSwitch", value);
            return definition;
        }
    }
}