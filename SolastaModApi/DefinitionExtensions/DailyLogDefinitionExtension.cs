using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DailyLogDefinitionExtensions
    {
        public static void SetHeaderHeight(this DailyLogDefinition definition, Int32 value)
        {
            definition.SetField("headerHeight", value);
        }

        public static void SetSubItemHeight(this DailyLogDefinition definition, Int32 value)
        {
            definition.SetField("subItemHeight", value);
        }

        public static void SetSubItemSpacing(this DailyLogDefinition definition, Int32 value)
        {
            definition.SetField("subItemSpacing", value);
        }

        public static void SetTableBottomMargin(this DailyLogDefinition definition, Int32 value)
        {
            definition.SetField("tableBottomMargin", value);
        }
    }
}