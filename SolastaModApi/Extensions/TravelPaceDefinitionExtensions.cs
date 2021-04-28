using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TravelPaceDefinitionExtensions
    {
        public static T SetPerceptionModifier<T>(this T entity, int value)
            where T : TravelPaceDefinition
        {
            entity.SetField("perceptionModifier", value);
            return entity;
        }

        public static T SetTravelDistancePerHour<T>(this T entity, float value)
            where T : TravelPaceDefinition
        {
            entity.SetField("travelDistancePerHour", value);
            return entity;
        }
    }
}