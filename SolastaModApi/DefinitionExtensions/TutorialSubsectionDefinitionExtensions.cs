using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class TutorialSubsectionDefinitionExtensions
    {
        public static T SetTutorialSteps<T>(this T definition, List<TutorialStepDefinition> value)
            where T : TutorialSubsectionDefinition
        {
            definition.SetField("tutorialSteps", value);
            return definition;
        }
    }
}