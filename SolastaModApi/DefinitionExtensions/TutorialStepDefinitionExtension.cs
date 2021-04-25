using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TutorialStepDefinitionExtensions
    {
        public static TutorialStepDefinition SetHideCharacterInspection(this TutorialStepDefinition definition, bool value)
        {
            definition.SetField("hideCharacterInspection", value);
            return definition;
        }

        public static TutorialStepDefinition SetHideJournal(this TutorialStepDefinition definition, bool value)
        {
            definition.SetField("hideJournal", value);
            return definition;
        }

        public static TutorialStepDefinition SetNextStepDefinition(this TutorialStepDefinition definition, TutorialStepDefinition value)
        {
            definition.SetField("nextStepDefinition", value);
            return definition;
        }
    }
}