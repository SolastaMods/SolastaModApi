using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DocumentTableDefinitionExtensions
    {
        public static DocumentTableDefinition SetHeaderHeight(this DocumentTableDefinition definition, float value)
        {
            definition.SetField("headerHeight", value);
            return definition;
        }

        public static DocumentTableDefinition SetIndentWidth(this DocumentTableDefinition definition, float value)
        {
            definition.SetField("indentWidth", value);
            return definition;
        }

        public static DocumentTableDefinition SetLineHeight(this DocumentTableDefinition definition, float value)
        {
            definition.SetField("lineHeight", value);
            return definition;
        }

        public static DocumentTableDefinition SetPageHeight(this DocumentTableDefinition definition, float value)
        {
            definition.SetField("pageHeight", value);
            return definition;
        }

        public static DocumentTableDefinition SetParagraphSpacing(this DocumentTableDefinition definition, float value)
        {
            definition.SetField("paragraphSpacing", value);
            return definition;
        }

        public static DocumentTableDefinition SetStyleDuplets(this DocumentTableDefinition definition, List<DocumentStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
            return definition;
        }

        public static DocumentTableDefinition SetWordSpacing(this DocumentTableDefinition definition, float value)
        {
            definition.SetField("wordSpacing", value);
            return definition;
        }
    }
}