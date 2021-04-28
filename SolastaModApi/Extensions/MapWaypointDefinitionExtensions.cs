using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MapWaypointDefinitionExtensions
    {
        public static T SetAllowFastTravel<T>(this T entity, bool value)
            where T : MapWaypointDefinition
        {
            entity.SetField("allowFastTravel", value);
            return entity;
        }

        public static T SetCameraAngle<T>(this T entity, float value)
            where T : MapWaypointDefinition
        {
            entity.SetField("cameraAngle", value);
            return entity;
        }

        public static T SetForceCameraOrientation<T>(this T entity, bool value)
            where T : MapWaypointDefinition
        {
            entity.SetField("forceCameraOrientation", value);
            return entity;
        }

        public static T SetLocationExit<T>(this T entity, bool value)
            where T : MapWaypointDefinition
        {
            entity.SetField("locationExit", value);
            return entity;
        }

        public static T SetLongRestAvailable<T>(this T entity, bool value)
            where T : MapWaypointDefinition
        {
            entity.SetField("longRestAvailable", value);
            return entity;
        }
    }
}