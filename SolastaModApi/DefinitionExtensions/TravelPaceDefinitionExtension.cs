using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TravelPaceDefinitionExtensions
    {
        public static TravelPaceDefinition SetPerceptionModifier(this TravelPaceDefinition definition, int value)
        {
            definition.SetField("perceptionModifier", value);
            return definition;
        }

        public static TravelPaceDefinition SetTravelDistancePerHour(this TravelPaceDefinition definition, float value)
        {
            definition.SetField("travelDistancePerHour", value);
            return definition;
        }
    }
}