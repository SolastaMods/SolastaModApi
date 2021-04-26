using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class AlignmentDefinitionExtensions
    {
        public static T SetDefaultPersonalityFlags<T>(this T definition, List<string> value)
            where T : AlignmentDefinition
        {
            definition.SetField("defaultPersonalityFlags", value);
            return definition;
        }

        public static T SetGoodnessAxis<T>(this T definition, int value)
            where T : AlignmentDefinition
        {
            definition.SetField("goodnessAxis", value);
            return definition;
        }

        public static T SetLawAxis<T>(this T definition, int value)
            where T : AlignmentDefinition
        {
            definition.SetField("lawAxis", value);
            return definition;
        }

        public static T SetOptionalPersonalityFlags<T>(this T definition, List<PersonalityFlagOccurence> value)
            where T : AlignmentDefinition
        {
            definition.SetField("optionalPersonalityFlags", value);
            return definition;
        }
    }
}