using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MapWaypointDefinitionExtensions
    {
        public static T SetAllowFastTravel<T>(this T definition, bool value)
            where T : MapWaypointDefinition
        {
            definition.SetField("allowFastTravel", value);
            return definition;
        }

        public static T SetCameraAngle<T>(this T definition, float value)
            where T : MapWaypointDefinition
        {
            definition.SetField("cameraAngle", value);
            return definition;
        }

        public static T SetForceCameraOrientation<T>(this T definition, bool value)
            where T : MapWaypointDefinition
        {
            definition.SetField("forceCameraOrientation", value);
            return definition;
        }

        public static T SetLocationExit<T>(this T definition, bool value)
            where T : MapWaypointDefinition
        {
            definition.SetField("locationExit", value);
            return definition;
        }

        public static T SetLongRestAvailable<T>(this T definition, bool value)
            where T : MapWaypointDefinition
        {
            definition.SetField("longRestAvailable", value);
            return definition;
        }
    }
}