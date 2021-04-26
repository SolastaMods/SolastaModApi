using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DateTimeDefinitionExtensions
    {
        public static T SetDay<T>(this T definition, int value)
            where T : DateTimeDefinition
        {
            definition.SetField("day", value);
            return definition;
        }

        public static T SetHour<T>(this T definition, int value)
            where T : DateTimeDefinition
        {
            definition.SetField("hour", value);
            return definition;
        }

        public static T SetMinute<T>(this T definition, int value)
            where T : DateTimeDefinition
        {
            definition.SetField("minute", value);
            return definition;
        }

        public static T SetMonth<T>(this T definition, int value)
            where T : DateTimeDefinition
        {
            definition.SetField("month", value);
            return definition;
        }

        public static T SetSeconds<T>(this T definition, int value)
            where T : DateTimeDefinition
        {
            definition.SetField("seconds", value);
            return definition;
        }

        public static T SetYear<T>(this T definition, int value)
            where T : DateTimeDefinition
        {
            definition.SetField("year", value);
            return definition;
        }
    }
}