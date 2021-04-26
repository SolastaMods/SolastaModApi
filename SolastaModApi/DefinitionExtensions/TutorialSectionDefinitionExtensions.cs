using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class TutorialSectionDefinitionExtensions
    {
        public static T SetSubsections<T>(this T definition, List<TutorialSubsectionDefinition> value)
            where T : TutorialSectionDefinition
        {
            definition.SetField("subsections", value);
            return definition;
        }
    }
}