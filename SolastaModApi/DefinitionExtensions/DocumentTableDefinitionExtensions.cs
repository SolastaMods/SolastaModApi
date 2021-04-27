using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class DocumentTableDefinitionExtensions
    {
        public static T SetHeaderHeight<T>(this T definition, float value)
            where T : DocumentTableDefinition
        {
            definition.SetField("headerHeight", value);
            return definition;
        }

        public static T SetIndentWidth<T>(this T definition, float value)
            where T : DocumentTableDefinition
        {
            definition.SetField("indentWidth", value);
            return definition;
        }

        public static T SetLineHeight<T>(this T definition, float value)
            where T : DocumentTableDefinition
        {
            definition.SetField("lineHeight", value);
            return definition;
        }

        public static T SetPageHeight<T>(this T definition, float value)
            where T : DocumentTableDefinition
        {
            definition.SetField("pageHeight", value);
            return definition;
        }

        public static T SetParagraphSpacing<T>(this T definition, float value)
            where T : DocumentTableDefinition
        {
            definition.SetField("paragraphSpacing", value);
            return definition;
        }

        public static T SetWordSpacing<T>(this T definition, float value)
            where T : DocumentTableDefinition
        {
            definition.SetField("wordSpacing", value);
            return definition;
        }
    }
}