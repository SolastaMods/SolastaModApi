using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TutorialTableDefinitionExtensions
    {
        public static T SetSectionLineHeight<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("sectionLineHeight", value);
            return definition;
        }

        public static T SetStepHeaderHeight<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("stepHeaderHeight", value);
            return definition;
        }

        public static T SetStepLineHeight<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("stepLineHeight", value);
            return definition;
        }

        public static T SetStepParagraphSpacing<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("stepParagraphSpacing", value);
            return definition;
        }

        public static T SetStepTitleHeight<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("stepTitleHeight", value);
            return definition;
        }

        public static T SetStepTralingHeight<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("stepTralingHeight", value);
            return definition;
        }

        public static T SetStepWordSpacing<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("stepWordSpacing", value);
            return definition;
        }

        public static T SetSubsectionIndentWidth<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("subsectionIndentWidth", value);
            return definition;
        }

        public static T SetSubsectionLineHeight<T>(this T definition, float value)
            where T : TutorialTableDefinition
        {
            definition.SetField("subsectionLineHeight", value);
            return definition;
        }
    }
}