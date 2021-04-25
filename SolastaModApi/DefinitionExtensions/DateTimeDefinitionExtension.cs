using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DateTimeDefinitionExtensions
    {
        public static DateTimeDefinition SetDay(this DateTimeDefinition definition, int value)
        {
            definition.SetField("day", value);
            return definition;
        }

        public static DateTimeDefinition SetHour(this DateTimeDefinition definition, int value)
        {
            definition.SetField("hour", value);
            return definition;
        }

        public static DateTimeDefinition SetMinute(this DateTimeDefinition definition, int value)
        {
            definition.SetField("minute", value);
            return definition;
        }

        public static DateTimeDefinition SetMonth(this DateTimeDefinition definition, int value)
        {
            definition.SetField("month", value);
            return definition;
        }

        public static DateTimeDefinition SetSeconds(this DateTimeDefinition definition, int value)
        {
            definition.SetField("seconds", value);
            return definition;
        }

        public static DateTimeDefinition SetYear(this DateTimeDefinition definition, int value)
        {
            definition.SetField("year", value);
            return definition;
        }
    }
}