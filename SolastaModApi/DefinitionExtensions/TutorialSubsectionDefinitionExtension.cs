using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TutorialSubsectionDefinitionExtensions
    {
        public static TutorialSubsectionDefinition SetTutorialSteps(this TutorialSubsectionDefinition definition, List<TutorialStepDefinition> value)
        {
            definition.SetField("tutorialSteps", value);
            return definition;
        }
    }
}