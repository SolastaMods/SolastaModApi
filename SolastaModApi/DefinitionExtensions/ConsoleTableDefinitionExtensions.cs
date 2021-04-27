using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ConsoleTableDefinitionExtensions
    {
        public static T SetIndentWidth<T>(this T definition, float value)
            where T : ConsoleTableDefinition
        {
            definition.SetField("indentWidth", value);
            return definition;
        }

        public static T SetLineHeight<T>(this T definition, float value)
            where T : ConsoleTableDefinition
        {
            definition.SetField("lineHeight", value);
            return definition;
        }

        public static T SetLineSpacing<T>(this T definition, float value)
            where T : ConsoleTableDefinition
        {
            definition.SetField("lineSpacing", value);
            return definition;
        }

        public static T SetWordSpacing<T>(this T definition, float value)
            where T : ConsoleTableDefinition
        {
            definition.SetField("wordSpacing", value);
            return definition;
        }
    }
}