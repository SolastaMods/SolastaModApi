using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DocumentTableDefinitionExtensions
    {
        public static T SetHeaderHeight<T>(this T entity, float value)
            where T : DocumentTableDefinition
        {
            entity.SetField("headerHeight", value);
            return entity;
        }

        public static T SetIndentWidth<T>(this T entity, float value)
            where T : DocumentTableDefinition
        {
            entity.SetField("indentWidth", value);
            return entity;
        }

        public static T SetLineHeight<T>(this T entity, float value)
            where T : DocumentTableDefinition
        {
            entity.SetField("lineHeight", value);
            return entity;
        }

        public static T SetPageHeight<T>(this T entity, float value)
            where T : DocumentTableDefinition
        {
            entity.SetField("pageHeight", value);
            return entity;
        }

        public static T SetParagraphSpacing<T>(this T entity, float value)
            where T : DocumentTableDefinition
        {
            entity.SetField("paragraphSpacing", value);
            return entity;
        }

        public static T SetWordSpacing<T>(this T entity, float value)
            where T : DocumentTableDefinition
        {
            entity.SetField("wordSpacing", value);
            return entity;
        }
    }
}