using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSenseExtensions
    {
        public static FeatureDefinitionSense SetSenseRange(this FeatureDefinitionSense definition, int value)
        {
            definition.SetField("senseRange", value);
            return definition;
        }

        public static FeatureDefinitionSense SetSenseType(this FeatureDefinitionSense definition, SenseMode.Type value)
        {
            definition.SetField("senseType", value);
            return definition;
        }

        public static FeatureDefinitionSense SetStealthBreakerRange(this FeatureDefinitionSense definition, int value)
        {
            definition.SetField("stealthBreakerRange", value);
            return definition;
        }
    }
}