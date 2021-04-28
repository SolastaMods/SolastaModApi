using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionSenseExtensions
    {
        public static T SetSenseRange<T>(this T entity, int value)
            where T : FeatureDefinitionSense
        {
            entity.SetField("senseRange", value);
            return entity;
        }

        public static T SetSenseType<T>(this T entity, SenseMode.Type value)
            where T : FeatureDefinitionSense
        {
            entity.SetField("senseType", value);
            return entity;
        }

        public static T SetStealthBreakerRange<T>(this T entity, int value)
            where T : FeatureDefinitionSense
        {
            entity.SetField("stealthBreakerRange", value);
            return entity;
        }
    }
}