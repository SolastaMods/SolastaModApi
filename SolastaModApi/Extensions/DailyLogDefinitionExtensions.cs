using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DailyLogDefinitionExtensions
    {
        public static T SetHeaderHeight<T>(this T entity, int value)
            where T : DailyLogDefinition
        {
            entity.SetField("headerHeight", value);
            return entity;
        }

        public static T SetSubItemHeight<T>(this T entity, int value)
            where T : DailyLogDefinition
        {
            entity.SetField("subItemHeight", value);
            return entity;
        }

        public static T SetSubItemSpacing<T>(this T entity, int value)
            where T : DailyLogDefinition
        {
            entity.SetField("subItemSpacing", value);
            return entity;
        }

        public static T SetTableBottomMargin<T>(this T entity, int value)
            where T : DailyLogDefinition
        {
            entity.SetField("tableBottomMargin", value);
            return entity;
        }
    }
}