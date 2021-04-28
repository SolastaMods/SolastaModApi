using SolastaModApi.Infrastructure;
using AK.Wwise;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class VoiceDefinitionExtensions
    {
        public static T SetAmplitude<T>(this T entity, float value)
            where T : VoiceDefinition
        {
            entity.SetField("amplitude", value);
            return entity;
        }

        public static T SetAvailableInCharacterCreation<T>(this T entity, bool value)
            where T : VoiceDefinition
        {
            entity.SetField("availableInCharacterCreation", value);
            return entity;
        }

        public static T SetIndividualName<T>(this T entity, string value)
            where T : VoiceDefinition
        {
            entity.SetField("individualName", value);
            return entity;
        }

        public static T SetSex<T>(this T entity, CreatureSex value)
            where T : VoiceDefinition
        {
            entity.SetField("sex", value);
            return entity;
        }

        public static T SetSpeechSpeed<T>(this T entity, float value)
            where T : VoiceDefinition
        {
            entity.SetField("speechSpeed", value);
            return entity;
        }

        public static T SetWavePath<T>(this T entity, string value)
            where T : VoiceDefinition
        {
            entity.SetField("wavePath", value);
            return entity;
        }

        public static T SetWavePrefix<T>(this T entity, string value)
            where T : VoiceDefinition
        {
            entity.SetField("wavePrefix", value);
            return entity;
        }

        public static T SetWwiseSuffix<T>(this T entity, string value)
            where T : VoiceDefinition
        {
            entity.SetField("wwiseSuffix", value);
            return entity;
        }

        public static T SetWwiseSwitch<T>(this T entity, Switch value)
            where T : VoiceDefinition
        {
            entity.SetField("wwiseSwitch", value);
            return entity;
        }
    }
}