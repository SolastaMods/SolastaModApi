using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionSenseExtensions
    {
        public static T SetSenseRange<T>(this T definition, int value)
            where T : FeatureDefinitionSense
        {
            definition.SetField("senseRange", value);
            return definition;
        }

        public static T SetSenseType<T>(this T definition, SenseMode.Type value)
            where T : FeatureDefinitionSense
        {
            definition.SetField("senseType", value);
            return definition;
        }

        public static T SetStealthBreakerRange<T>(this T definition, int value)
            where T : FeatureDefinitionSense
        {
            definition.SetField("stealthBreakerRange", value);
            return definition;
        }
    }
}