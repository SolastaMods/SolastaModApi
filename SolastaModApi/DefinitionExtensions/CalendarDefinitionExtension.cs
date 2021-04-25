using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CalendarDefinitionExtensions
    {
        public static void SetDaysPerMonth(this CalendarDefinition definition, Int32 value)
        {
            definition.SetField("daysPerMonth", value);
        }

        public static void SetMonthsNames(this CalendarDefinition definition, String[] value)
        {
            definition.SetField("monthsNames", value);
        }

        public static void SetMonthsPerYear(this CalendarDefinition definition, Int32 value)
        {
            definition.SetField("monthsPerYear", value);
        }

        public static void SetYearFormat(this CalendarDefinition definition, String value)
        {
            definition.SetField("yearFormat", value);
        }

        public static void SetYearTags(this CalendarDefinition definition, CalendarDefinition.YearTag[] value)
        {
            definition.SetField("yearTags", value);
        }
    }
}