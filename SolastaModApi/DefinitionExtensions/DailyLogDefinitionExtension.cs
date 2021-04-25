using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DailyLogDefinitionExtensions
    {
        public static DailyLogDefinition SetHeaderHeight(this DailyLogDefinition definition, int value)
        {
            definition.SetField("headerHeight", value);
            return definition;
        }

        public static DailyLogDefinition SetSubItemHeight(this DailyLogDefinition definition, int value)
        {
            definition.SetField("subItemHeight", value);
            return definition;
        }

        public static DailyLogDefinition SetSubItemSpacing(this DailyLogDefinition definition, int value)
        {
            definition.SetField("subItemSpacing", value);
            return definition;
        }

        public static DailyLogDefinition SetTableBottomMargin(this DailyLogDefinition definition, int value)
        {
            definition.SetField("tableBottomMargin", value);
            return definition;
        }
    }
}