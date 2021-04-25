using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ConsoleTableDefinitionExtensions
    {
        public static ConsoleTableDefinition SetIndentWidth(this ConsoleTableDefinition definition, float value)
        {
            definition.SetField("indentWidth", value);
            return definition;
        }

        public static ConsoleTableDefinition SetLineHeight(this ConsoleTableDefinition definition, float value)
        {
            definition.SetField("lineHeight", value);
            return definition;
        }

        public static ConsoleTableDefinition SetLineSpacing(this ConsoleTableDefinition definition, float value)
        {
            definition.SetField("lineSpacing", value);
            return definition;
        }

        public static ConsoleTableDefinition SetStyleDuplets(this ConsoleTableDefinition definition, List<ConsoleStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
            return definition;
        }

        public static ConsoleTableDefinition SetWordSpacing(this ConsoleTableDefinition definition, float value)
        {
            definition.SetField("wordSpacing", value);
            return definition;
        }
    }
}