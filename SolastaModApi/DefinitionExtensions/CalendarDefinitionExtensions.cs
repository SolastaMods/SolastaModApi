using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class CalendarDefinitionExtensions
    {
        public static T SetDaysPerMonth<T>(this T definition, int value)
            where T : CalendarDefinition
        {
            definition.SetField("daysPerMonth", value);
            return definition;
        }

        public static T SetMonthsNames<T>(this T definition, string[] value)
            where T : CalendarDefinition
        {
            definition.SetField("monthsNames", value);
            return definition;
        }

        public static T SetMonthsPerYear<T>(this T definition, int value)
            where T : CalendarDefinition
        {
            definition.SetField("monthsPerYear", value);
            return definition;
        }

        public static T SetYearFormat<T>(this T definition, string value)
            where T : CalendarDefinition
        {
            definition.SetField("yearFormat", value);
            return definition;
        }

        public static T SetYearTags<T>(this T definition, CalendarDefinition.YearTag[] value)
            where T : CalendarDefinition
        {
            definition.SetField("yearTags", value);
            return definition;
        }
    }
}