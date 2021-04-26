using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TutorialStepDefinitionExtensions
    {
        public static T SetHideCharacterInspection<T>(this T definition, bool value)
            where T : TutorialStepDefinition
        {
            definition.SetField("hideCharacterInspection", value);
            return definition;
        }

        public static T SetHideJournal<T>(this T definition, bool value)
            where T : TutorialStepDefinition
        {
            definition.SetField("hideJournal", value);
            return definition;
        }

        public static T SetNextStepDefinition<T>(this T definition, TutorialStepDefinition value)
            where T : TutorialStepDefinition
        {
            definition.SetField("nextStepDefinition", value);
            return definition;
        }
    }
}