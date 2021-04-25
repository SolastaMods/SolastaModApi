using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DateTimeDefinitionExtensions
    {
        public static void SetDay(this DateTimeDefinition definition, Int32 value)
        {
            definition.SetField("day", value);
        }

        public static void SetHour(this DateTimeDefinition definition, Int32 value)
        {
            definition.SetField("hour", value);
        }

        public static void SetMinute(this DateTimeDefinition definition, Int32 value)
        {
            definition.SetField("minute", value);
        }

        public static void SetMonth(this DateTimeDefinition definition, Int32 value)
        {
            definition.SetField("month", value);
        }

        public static void SetSeconds(this DateTimeDefinition definition, Int32 value)
        {
            definition.SetField("seconds", value);
        }

        public static void SetYear(this DateTimeDefinition definition, Int32 value)
        {
            definition.SetField("year", value);
        }
    }
}