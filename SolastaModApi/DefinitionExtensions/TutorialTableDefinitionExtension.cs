using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TutorialTableDefinitionExtensions
    {
        public static TutorialTableDefinition SetSectionLineHeight(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("sectionLineHeight", value);
            return definition;
        }

        public static TutorialTableDefinition SetSections(this TutorialTableDefinition definition, List<TutorialSectionDefinition> value)
        {
            definition.SetField("sections", value);
            return definition;
        }

        public static TutorialTableDefinition SetStepHeaderHeight(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("stepHeaderHeight", value);
            return definition;
        }

        public static TutorialTableDefinition SetStepLineHeight(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("stepLineHeight", value);
            return definition;
        }

        public static TutorialTableDefinition SetStepParagraphSpacing(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("stepParagraphSpacing", value);
            return definition;
        }

        public static TutorialTableDefinition SetStepTitleHeight(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("stepTitleHeight", value);
            return definition;
        }

        public static TutorialTableDefinition SetStepTralingHeight(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("stepTralingHeight", value);
            return definition;
        }

        public static TutorialTableDefinition SetStepWordSpacing(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("stepWordSpacing", value);
            return definition;
        }

        public static TutorialTableDefinition SetStyleDuplets(this TutorialTableDefinition definition, List<TutorialStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
            return definition;
        }

        public static TutorialTableDefinition SetSubsectionIndentWidth(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("subsectionIndentWidth", value);
            return definition;
        }

        public static TutorialTableDefinition SetSubsectionLineHeight(this TutorialTableDefinition definition, float value)
        {
            definition.SetField("subsectionLineHeight", value);
            return definition;
        }
    }
}