using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TutorialTableDefinitionExtensions
    {
        public static void SetSectionLineHeight(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("sectionLineHeight", value);
        }

        public static void SetSections(this TutorialTableDefinition definition, List<TutorialSectionDefinition> value)
        {
            definition.SetField("sections", value);
        }

        public static void SetStepHeaderHeight(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("stepHeaderHeight", value);
        }

        public static void SetStepLineHeight(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("stepLineHeight", value);
        }

        public static void SetStepParagraphSpacing(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("stepParagraphSpacing", value);
        }

        public static void SetStepTitleHeight(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("stepTitleHeight", value);
        }

        public static void SetStepTralingHeight(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("stepTralingHeight", value);
        }

        public static void SetStepWordSpacing(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("stepWordSpacing", value);
        }

        public static void SetStyleDuplets(this TutorialTableDefinition definition, List<TutorialStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
        }

        public static void SetSubsectionIndentWidth(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("subsectionIndentWidth", value);
        }

        public static void SetSubsectionLineHeight(this TutorialTableDefinition definition, Single value)
        {
            definition.SetField("subsectionLineHeight", value);
        }
    }
}