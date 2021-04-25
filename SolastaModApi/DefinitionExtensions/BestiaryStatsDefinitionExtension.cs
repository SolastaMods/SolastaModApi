using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BestiaryStatsDefinitionExtensions
    {
        public static void SetLineHeight(this BestiaryStatsDefinition definition, Single value)
        {
            definition.SetField("lineHeight", value);
        }

        public static void SetLineSpacing(this BestiaryStatsDefinition definition, Single value)
        {
            definition.SetField("lineSpacing", value);
        }

        public static void SetStyleDuplets(this BestiaryStatsDefinition definition, List<BestiaryStatStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
        }

        public static void SetWordSpacing(this BestiaryStatsDefinition definition, Single value)
        {
            definition.SetField("wordSpacing", value);
        }
    }
}