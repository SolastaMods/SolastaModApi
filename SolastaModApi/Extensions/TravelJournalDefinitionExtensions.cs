using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TravelJournalDefinitionExtensions
    {
        public static T SetIndentWidth<T>(this T entity, float value)
            where T : TravelJournalDefinition
        {
            entity.SetField("indentWidth", value);
            return entity;
        }

        public static T SetLineHeight<T>(this T entity, float value)
            where T : TravelJournalDefinition
        {
            entity.SetField("lineHeight", value);
            return entity;
        }

        public static T SetLineSpacing<T>(this T entity, float value)
            where T : TravelJournalDefinition
        {
            entity.SetField("lineSpacing", value);
            return entity;
        }

        public static T SetMinHeight<T>(this T entity, float value)
            where T : TravelJournalDefinition
        {
            entity.SetField("minHeight", value);
            return entity;
        }

        public static T SetWordSpacing<T>(this T entity, float value)
            where T : TravelJournalDefinition
        {
            entity.SetField("wordSpacing", value);
            return entity;
        }
    }
}