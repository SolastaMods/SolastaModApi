using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TutorialTocDefinitionExtensions
    {
        public static void SetSectionLineHeight(this TutorialTocDefinition definition, Single value)
        {
            definition.SetField("sectionLineHeight", value);
        }

        public static void SetSubsectionHeaderHeight(this TutorialTocDefinition definition, Single value)
        {
            definition.SetField("subsectionHeaderHeight", value);
        }

        public static void SetSubsectionIndentWidth(this TutorialTocDefinition definition, Single value)
        {
            definition.SetField("subsectionIndentWidth", value);
        }

        public static void SetSubsectionLineHeight(this TutorialTocDefinition definition, Single value)
        {
            definition.SetField("subsectionLineHeight", value);
        }

        public static void SetSubsectionLineSpacing(this TutorialTocDefinition definition, Single value)
        {
            definition.SetField("subsectionLineSpacing", value);
        }

        public static void SetSubsectionTrailingHeight(this TutorialTocDefinition definition, Single value)
        {
            definition.SetField("subsectionTrailingHeight", value);
        }
    }
}