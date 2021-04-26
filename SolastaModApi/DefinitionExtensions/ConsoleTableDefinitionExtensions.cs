using SolastaModApi.Infrastructure;
using System.Collections.Generic;

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

        public static T SetStyleDuplets<T>(this T definition, List<ConsoleStyleDuplet> value)
            where T : ConsoleTableDefinition
        {
            definition.SetField("styleDuplets", value);
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