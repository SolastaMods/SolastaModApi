using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TravelPaceDefinitionExtensions
    {
        public static T SetPerceptionModifier<T>(this T definition, int value)
            where T : TravelPaceDefinition
        {
            definition.SetField("perceptionModifier", value);
            return definition;
        }

        public static T SetTravelDistancePerHour<T>(this T definition, float value)
            where T : TravelPaceDefinition
        {
            definition.SetField("travelDistancePerHour", value);
            return definition;
        }
    }
}