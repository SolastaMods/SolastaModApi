using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BanterEventDefinitionExtensions
    {
        public static T SetCanUseWhileCautious<T>(this T definition, bool value)
            where T : BanterEventDefinition
        {
            definition.SetField("canUseWhileCautious", value);
            return definition;
        }

        public static T SetEventProbability<T>(this T definition, float value)
            where T : BanterEventDefinition
        {
            definition.SetField("eventProbability", value);
            return definition;
        }

        public static T SetEventTrigger<T>(this T definition, string value)
            where T : BanterEventDefinition
        {
            definition.SetField("eventTrigger", value);
            return definition;
        }

        public static T SetPlaybackDelay<T>(this T definition, float value)
            where T : BanterEventDefinition
        {
            definition.SetField("playbackDelay", value);
            return definition;
        }

        public static T SetSearchKey<T>(this T definition, string value)
            where T : BanterEventDefinition
        {
            definition.SetField("searchKey", value);
            return definition;
        }

        public static T SetSelfProbability<T>(this T definition, float value)
            where T : BanterEventDefinition
        {
            definition.SetField("selfProbability", value);
            return definition;
        }
    }
}