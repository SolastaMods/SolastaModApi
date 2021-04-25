using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TravelJournalDefinitionExtensions
    {
        public static void SetIndentWidth(this TravelJournalDefinition definition, Single value)
        {
            definition.SetField("indentWidth", value);
        }

        public static void SetLineHeight(this TravelJournalDefinition definition, Single value)
        {
            definition.SetField("lineHeight", value);
        }

        public static void SetLineSpacing(this TravelJournalDefinition definition, Single value)
        {
            definition.SetField("lineSpacing", value);
        }

        public static void SetMinHeight(this TravelJournalDefinition definition, Single value)
        {
            definition.SetField("minHeight", value);
        }

        public static void SetStyleDuplets(this TravelJournalDefinition definition, List<TravelStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
        }

        public static void SetWordSpacing(this TravelJournalDefinition definition, Single value)
        {
            definition.SetField("wordSpacing", value);
        }
    }
}