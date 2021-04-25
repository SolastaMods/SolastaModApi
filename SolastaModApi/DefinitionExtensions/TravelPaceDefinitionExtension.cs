using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TravelPaceDefinitionExtensions
    {
        public static void SetPerceptionModifier(this TravelPaceDefinition definition, Int32 value)
        {
            definition.SetField("perceptionModifier", value);
        }

        public static void SetTravelDistancePerHour(this TravelPaceDefinition definition, Single value)
        {
            definition.SetField("travelDistancePerHour", value);
        }
    }
}