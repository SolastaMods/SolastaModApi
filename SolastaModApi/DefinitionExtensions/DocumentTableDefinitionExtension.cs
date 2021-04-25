using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DocumentTableDefinitionExtensions
    {
        public static void SetHeaderHeight(this DocumentTableDefinition definition, Single value)
        {
            definition.SetField("headerHeight", value);
        }

        public static void SetIndentWidth(this DocumentTableDefinition definition, Single value)
        {
            definition.SetField("indentWidth", value);
        }

        public static void SetLineHeight(this DocumentTableDefinition definition, Single value)
        {
            definition.SetField("lineHeight", value);
        }

        public static void SetPageHeight(this DocumentTableDefinition definition, Single value)
        {
            definition.SetField("pageHeight", value);
        }

        public static void SetParagraphSpacing(this DocumentTableDefinition definition, Single value)
        {
            definition.SetField("paragraphSpacing", value);
        }

        public static void SetStyleDuplets(this DocumentTableDefinition definition, List<DocumentStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
        }

        public static void SetWordSpacing(this DocumentTableDefinition definition, Single value)
        {
            definition.SetField("wordSpacing", value);
        }
    }
}