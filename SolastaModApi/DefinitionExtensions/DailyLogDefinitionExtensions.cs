using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DailyLogDefinitionExtensions
    {
        public static T SetHeaderHeight<T>(this T definition, int value)
            where T : DailyLogDefinition
        {
            definition.SetField("headerHeight", value);
            return definition;
        }

        public static T SetSubItemHeight<T>(this T definition, int value)
            where T : DailyLogDefinition
        {
            definition.SetField("subItemHeight", value);
            return definition;
        }

        public static T SetSubItemSpacing<T>(this T definition, int value)
            where T : DailyLogDefinition
        {
            definition.SetField("subItemSpacing", value);
            return definition;
        }

        public static T SetTableBottomMargin<T>(this T definition, int value)
            where T : DailyLogDefinition
        {
            definition.SetField("tableBottomMargin", value);
            return definition;
        }
    }
}