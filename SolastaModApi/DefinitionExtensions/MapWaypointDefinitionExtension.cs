using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MapWaypointDefinitionExtensions
    {
        public static void SetAllowFastTravel(this MapWaypointDefinition definition, Boolean value)
        {
            definition.SetField("allowFastTravel", value);
        }

        public static void SetCameraAngle(this MapWaypointDefinition definition, Single value)
        {
            definition.SetField("cameraAngle", value);
        }

        public static void SetForceCameraOrientation(this MapWaypointDefinition definition, Boolean value)
        {
            definition.SetField("forceCameraOrientation", value);
        }

        public static void SetLocationExit(this MapWaypointDefinition definition, Boolean value)
        {
            definition.SetField("locationExit", value);
        }

        public static void SetLongRestAvailable(this MapWaypointDefinition definition, Boolean value)
        {
            definition.SetField("longRestAvailable", value);
        }
    }
}