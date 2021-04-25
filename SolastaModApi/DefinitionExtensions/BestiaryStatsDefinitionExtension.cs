using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BestiaryStatsDefinitionExtensions
    {
        public static BestiaryStatsDefinition SetLineHeight(this BestiaryStatsDefinition definition, float value)
        {
            definition.SetField("lineHeight", value);
            return definition;
        }

        public static BestiaryStatsDefinition SetLineSpacing(this BestiaryStatsDefinition definition, float value)
        {
            definition.SetField("lineSpacing", value);
            return definition;
        }

        public static BestiaryStatsDefinition SetStyleDuplets(this BestiaryStatsDefinition definition, List<BestiaryStatStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
            return definition;
        }

        public static BestiaryStatsDefinition SetWordSpacing(this BestiaryStatsDefinition definition, float value)
        {
            definition.SetField("wordSpacing", value);
            return definition;
        }
    }
}