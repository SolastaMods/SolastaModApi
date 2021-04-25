using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TutorialTocDefinitionExtensions
    {
        public static TutorialTocDefinition SetSectionLineHeight(this TutorialTocDefinition definition, float value)
        {
            definition.SetField("sectionLineHeight", value);
            return definition;
        }

        public static TutorialTocDefinition SetSubsectionHeaderHeight(this TutorialTocDefinition definition, float value)
        {
            definition.SetField("subsectionHeaderHeight", value);
            return definition;
        }

        public static TutorialTocDefinition SetSubsectionIndentWidth(this TutorialTocDefinition definition, float value)
        {
            definition.SetField("subsectionIndentWidth", value);
            return definition;
        }

        public static TutorialTocDefinition SetSubsectionLineHeight(this TutorialTocDefinition definition, float value)
        {
            definition.SetField("subsectionLineHeight", value);
            return definition;
        }

        public static TutorialTocDefinition SetSubsectionLineSpacing(this TutorialTocDefinition definition, float value)
        {
            definition.SetField("subsectionLineSpacing", value);
            return definition;
        }

        public static TutorialTocDefinition SetSubsectionTrailingHeight(this TutorialTocDefinition definition, float value)
        {
            definition.SetField("subsectionTrailingHeight", value);
            return definition;
        }
    }
}