using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ConsoleTableDefinitionExtensions
    {
        public static T SetIndentWidth<T>(this T entity, float value)
            where T : ConsoleTableDefinition
        {
            entity.SetField("indentWidth", value);
            return entity;
        }

        public static T SetLineHeight<T>(this T entity, float value)
            where T : ConsoleTableDefinition
        {
            entity.SetField("lineHeight", value);
            return entity;
        }

        public static T SetLineSpacing<T>(this T entity, float value)
            where T : ConsoleTableDefinition
        {
            entity.SetField("lineSpacing", value);
            return entity;
        }

        public static T SetWordSpacing<T>(this T entity, float value)
            where T : ConsoleTableDefinition
        {
            entity.SetField("wordSpacing", value);
            return entity;
        }
    }
}