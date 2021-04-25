using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CalendarDefinitionExtensions
    {
        public static CalendarDefinition SetDaysPerMonth(this CalendarDefinition definition, int value)
        {
            definition.SetField("daysPerMonth", value);
            return definition;
        }

        public static CalendarDefinition SetMonthsNames(this CalendarDefinition definition, string[] value)
        {
            definition.SetField("monthsNames", value);
            return definition;
        }

        public static CalendarDefinition SetMonthsPerYear(this CalendarDefinition definition, int value)
        {
            definition.SetField("monthsPerYear", value);
            return definition;
        }

        public static CalendarDefinition SetYearFormat(this CalendarDefinition definition, string value)
        {
            definition.SetField("yearFormat", value);
            return definition;
        }

        public static CalendarDefinition SetYearTags(this CalendarDefinition definition, CalendarDefinition.YearTag[] value)
        {
            definition.SetField("yearTags", value);
            return definition;
        }
    }
}