using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ConsoleTableDefinitionExtensions
    {
        public static void SetIndentWidth(this ConsoleTableDefinition definition, Single value)
        {
            definition.SetField("indentWidth", value);
        }

        public static void SetLineHeight(this ConsoleTableDefinition definition, Single value)
        {
            definition.SetField("lineHeight", value);
        }

        public static void SetLineSpacing(this ConsoleTableDefinition definition, Single value)
        {
            definition.SetField("lineSpacing", value);
        }

        public static void SetStyleDuplets(this ConsoleTableDefinition definition, List<ConsoleStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
        }

        public static void SetWordSpacing(this ConsoleTableDefinition definition, Single value)
        {
            definition.SetField("wordSpacing", value);
        }
    }
}