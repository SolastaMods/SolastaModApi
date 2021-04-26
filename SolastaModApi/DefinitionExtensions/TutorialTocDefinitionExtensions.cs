using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TutorialTocDefinitionExtensions
    {
        public static T SetSectionLineHeight<T>(this T definition, float value)
            where T : TutorialTocDefinition
        {
            definition.SetField("sectionLineHeight", value);
            return definition;
        }

        public static T SetSubsectionHeaderHeight<T>(this T definition, float value)
            where T : TutorialTocDefinition
        {
            definition.SetField("subsectionHeaderHeight", value);
            return definition;
        }

        public static T SetSubsectionIndentWidth<T>(this T definition, float value)
            where T : TutorialTocDefinition
        {
            definition.SetField("subsectionIndentWidth", value);
            return definition;
        }

        public static T SetSubsectionLineHeight<T>(this T definition, float value)
            where T : TutorialTocDefinition
        {
            definition.SetField("subsectionLineHeight", value);
            return definition;
        }

        public static T SetSubsectionLineSpacing<T>(this T definition, float value)
            where T : TutorialTocDefinition
        {
            definition.SetField("subsectionLineSpacing", value);
            return definition;
        }

        public static T SetSubsectionTrailingHeight<T>(this T definition, float value)
            where T : TutorialTocDefinition
        {
            definition.SetField("subsectionTrailingHeight", value);
            return definition;
        }
    }
}