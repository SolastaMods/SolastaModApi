using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TutorialSectionDefinitionExtensions
    {
        public static TutorialSectionDefinition SetSubsections(this TutorialSectionDefinition definition, List<TutorialSubsectionDefinition> value)
        {
            definition.SetField("subsections", value);
            return definition;
        }
    }
}