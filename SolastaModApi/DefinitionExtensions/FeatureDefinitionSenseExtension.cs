using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSenseExtensions
    {
        public static void SetSenseRange(this FeatureDefinitionSense definition, Int32 value)
        {
            definition.SetField("senseRange", value);
        }

        public static void SetSenseType(this FeatureDefinitionSense definition, SenseMode.Type value)
        {
            definition.SetField("senseType", value);
        }

        public static void SetStealthBreakerRange(this FeatureDefinitionSense definition, Int32 value)
        {
            definition.SetField("stealthBreakerRange", value);
        }
    }
}