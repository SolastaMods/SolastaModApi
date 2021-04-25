using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TravelJournalDefinitionExtensions
    {
        public static TravelJournalDefinition SetIndentWidth(this TravelJournalDefinition definition, float value)
        {
            definition.SetField("indentWidth", value);
            return definition;
        }

        public static TravelJournalDefinition SetLineHeight(this TravelJournalDefinition definition, float value)
        {
            definition.SetField("lineHeight", value);
            return definition;
        }

        public static TravelJournalDefinition SetLineSpacing(this TravelJournalDefinition definition, float value)
        {
            definition.SetField("lineSpacing", value);
            return definition;
        }

        public static TravelJournalDefinition SetMinHeight(this TravelJournalDefinition definition, float value)
        {
            definition.SetField("minHeight", value);
            return definition;
        }

        public static TravelJournalDefinition SetStyleDuplets(this TravelJournalDefinition definition, List<TravelStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
            return definition;
        }

        public static TravelJournalDefinition SetWordSpacing(this TravelJournalDefinition definition, float value)
        {
            definition.SetField("wordSpacing", value);
            return definition;
        }
    }
}