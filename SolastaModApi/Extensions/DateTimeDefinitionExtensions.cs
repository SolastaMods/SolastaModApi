using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DateTimeDefinitionExtensions
    {
        public static T SetDay<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("day", value);
            return entity;
        }

        public static T SetHour<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("hour", value);
            return entity;
        }

        public static T SetMinute<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("minute", value);
            return entity;
        }

        public static T SetMonth<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("month", value);
            return entity;
        }

        public static T SetSeconds<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("seconds", value);
            return entity;
        }

        public static T SetYear<T>(this T entity, int value)
            where T : DateTimeDefinition
        {
            entity.SetField("year", value);
            return entity;
        }
    }
}