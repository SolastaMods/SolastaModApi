using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MapWaypointDefinitionExtensions
    {
        public static MapWaypointDefinition SetAllowFastTravel(this MapWaypointDefinition definition, bool value)
        {
            definition.SetField("allowFastTravel", value);
            return definition;
        }

        public static MapWaypointDefinition SetCameraAngle(this MapWaypointDefinition definition, float value)
        {
            definition.SetField("cameraAngle", value);
            return definition;
        }

        public static MapWaypointDefinition SetForceCameraOrientation(this MapWaypointDefinition definition, bool value)
        {
            definition.SetField("forceCameraOrientation", value);
            return definition;
        }

        public static MapWaypointDefinition SetLocationExit(this MapWaypointDefinition definition, bool value)
        {
            definition.SetField("locationExit", value);
            return definition;
        }

        public static MapWaypointDefinition SetLongRestAvailable(this MapWaypointDefinition definition, bool value)
        {
            definition.SetField("longRestAvailable", value);
            return definition;
        }
    }
}