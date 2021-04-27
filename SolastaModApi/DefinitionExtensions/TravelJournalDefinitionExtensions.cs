using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TravelJournalDefinitionExtensions
    {
        public static T SetIndentWidth<T>(this T definition, float value)
            where T : TravelJournalDefinition
        {
            definition.SetField("indentWidth", value);
            return definition;
        }

        public static T SetLineHeight<T>(this T definition, float value)
            where T : TravelJournalDefinition
        {
            definition.SetField("lineHeight", value);
            return definition;
        }

        public static T SetLineSpacing<T>(this T definition, float value)
            where T : TravelJournalDefinition
        {
            definition.SetField("lineSpacing", value);
            return definition;
        }

        public static T SetMinHeight<T>(this T definition, float value)
            where T : TravelJournalDefinition
        {
            definition.SetField("minHeight", value);
            return definition;
        }

        public static T SetWordSpacing<T>(this T definition, float value)
            where T : TravelJournalDefinition
        {
            definition.SetField("wordSpacing", value);
            return definition;
        }
    }
}