using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TravelActivityDefinitionExtensions
    {
        public static T SetFatigueImpactPerHour<T>(this T entity, float value)
            where T : TravelActivityDefinition
        {
            entity.SetField("fatigueImpactPerHour", value);
            return entity;
        }

        public static T SetIsDynamic<T>(this T entity, bool value)
            where T : TravelActivityDefinition
        {
            entity.SetField("isDynamic", value);
            return entity;
        }

        public static T SetNavigationActivity<T>(this T entity, bool value)
            where T : TravelActivityDefinition
        {
            entity.SetField("navigationActivity", value);
            return entity;
        }

        public static T SetRestActivity<T>(this T entity, bool value)
            where T : TravelActivityDefinition
        {
            entity.SetField("restActivity", value);
            return entity;
        }

        public static T SetStandardDurationHours<T>(this T entity, int value)
            where T : TravelActivityDefinition
        {
            entity.SetField("standardDurationHours", value);
            return entity;
        }

        public static T SetStandardStartHour<T>(this T entity, int value)
            where T : TravelActivityDefinition
        {
            entity.SetField("standardStartHour", value);
            return entity;
        }
    }
}