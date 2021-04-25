using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TutorialStepDefinitionExtensions
    {
        public static void SetHideCharacterInspection(this TutorialStepDefinition definition, Boolean value)
        {
            definition.SetField("hideCharacterInspection", value);
        }

        public static void SetHideJournal(this TutorialStepDefinition definition, Boolean value)
        {
            definition.SetField("hideJournal", value);
        }

        public static void SetNextStepDefinition(this TutorialStepDefinition definition, TutorialStepDefinition value)
        {
            definition.SetField("nextStepDefinition", value);
        }
    }
}